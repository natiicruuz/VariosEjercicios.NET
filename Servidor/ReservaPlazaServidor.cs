using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using XML;

namespace Servidor
{
    public class ServidorParkings
    {
        private static readonly bool[] parkings = new bool[100];

        public static void IniciarServidor()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();
            Console.WriteLine("Servidor en espera de conexiones...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Thread hilo = new Thread(() => ProcesarSolicitud(client));
                hilo.Start();
            }
        }

        private static void ProcesarSolicitud(TcpClient client)
        {
            try
            {
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string mensajeXML = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Procesar la solicitud de reserva utilizando XMLConverter
                    var solicitud = XMLConverter.LeerSolicitudReservaXML(mensajeXML);

                    // Reservar parking basándose en la solicitud
                    bool exito = ReservarParking(solicitud.NombreComprador, solicitud.TieneCargador, out int numeroPlaza);

                    // Crear la respuesta en formato XML
                    string respuestaXML = XMLConverter.CrearRespuestaReservaXML(
                        exito ? 1 : 0, // Código: 1 si tuvo éxito, 0 si falló
                        exito ? $"Reserva confirmada para la plaza número {numeroPlaza}." : "No hay parkings disponibles.",
                        numeroPlaza
                    );

                    byte[] respuestaBytes = Encoding.UTF8.GetBytes(respuestaXML);

                    // Enviar la respuesta al cliente
                    stream.Write(respuestaBytes, 0, respuestaBytes.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }

        private static bool ReservarParking(string tipoReserva, bool requiereCargador, out int numeroPlaza)
        {
            numeroPlaza = -1;

            lock (parkings)
            {
                int inicio = requiereCargador ? 0 : 10;  // Si necesita cargador, solo se consideran las plazas de la 0 a la 9
                int fin = requiereCargador ? 10 : parkings.Length;

                for (int i = inicio; i < fin; i++)
                {
                    if (!parkings[i])
                    {
                        parkings[i] = true;
                        numeroPlaza = i;
                        Console.WriteLine($"Parking {i} reservado ({tipoReserva}, requiere cargador: {requiereCargador})");
                        return true;
                    }
                }
            }

            Console.WriteLine($"No hay parkings disponibles para {(requiereCargador ? "cargador eléctrico" : "sin cargador")}");
            return false;
        }

    }
}
