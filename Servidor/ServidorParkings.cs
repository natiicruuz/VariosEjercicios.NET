using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using XML;
using System.Xml;

namespace Servidor
{
    public class ServidorParkings
    {
        private static readonly bool[] parkings = new bool[100];

        public static async Task IniciarServidorAsync()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();
            Console.WriteLine("Servidor en espera de conexiones...");

            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                _ = ProcesarSolicitudAsync(client);
            }
        }

        private static async Task ProcesarSolicitudAsync(TcpClient client)
        {
            try
            {
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string mensajeXML = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    var solicitud = XMLConverter.LeerSolicitudReservaXML(mensajeXML);
                    bool exito = ReservarParking(solicitud.TipoReserva);

                    string respuestaXML = XMLConverter.CrearRespuestaReservaXML(exito);
                    byte[] respuestaBytes = Encoding.UTF8.GetBytes(respuestaXML);
                    await stream.WriteAsync(respuestaBytes, 0, respuestaBytes.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static bool ReservarParking(string tipoReserva)
        {
            lock (parkings)
            {
                for (int i = 0; i < parkings.Length; i++)
                {
                    if (!parkings[i])
                    {
                        parkings[i] = true;
                        Console.WriteLine($"Parking {i} reservado ({tipoReserva})");
                        return true;
                    }
                }
            }
            Console.WriteLine("No hay parkings disponibles");
            return false;
        }
    }
}
