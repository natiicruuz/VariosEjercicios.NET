using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using XML;
using System.Xml;

namespace Servidor
{

    public class Servidorsalas
    {
        private static readonly bool[] salas = new bool[100];

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

                    // Procesar la solicitud de reserva
                    var solicitud = XMLConverter.LeerSolicitudReservaXML(mensajeXML);
                    bool exito = ReservarSala(solicitud.TipoReserva);

                    // Crear la respuesta en formato XML
                    string respuestaXML = XMLConverter.CrearRespuestaReservaXML(exito);
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

        private static bool ReservarSala(string tipoReserva)
        {
            lock (salas)
            {
                for (int i = 0; i < salas.Length; i++)
                {
                    if (!salas[i])
                    {
                        salas[i] = true;
                        Console.WriteLine($"Sala {i} reservado ({tipoReserva})");
                        return true;
                    }
                }
            }
            Console.WriteLine("No hay salas disponibles");
            return false;
        }
    }
}