using System.Net.Sockets;
using System.Net;
using System.Text;
using XML;
using System.Threading.Tasks;

namespace Servidor
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Servidor arrancado!");
            await ServidorBicis.IniciarServidorAsync();
        }
    }

    public class ServidorBicis
    {
        private static readonly bool[] bicis = new bool[40];

        public static async Task IniciarServidorAsync()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();
            Console.WriteLine("Servidor en espera de conexiones...");

            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                _ = ProcesarSolicitudAsync(client); // Ejecuta cada solicitud asincrónicamente
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

                    var solicitud = XmlConverter.LeerSolicitudReservaXML(mensajeXML);
                    bool exito = ReservarAsiento(solicitud.TipoBici);

                    string respuestaXML = XmlConverter.CrearRespuestaReservaXML(exito);

                    byte[] respuestaBytes = Encoding.UTF8.GetBytes(respuestaXML);
                    await stream.WriteAsync(respuestaBytes, 0, respuestaBytes.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static bool ReservarAsiento(string tipoBici)
        {
            lock (bicis)
            {
                for (int i = 0; i < bicis.Length; i++)
                {
                    if (!bicis[i])
                    {
                        bicis[i] = true;
                        Console.WriteLine($"Asiento {i} reservado como {tipoBici}");
                        return true;
                    }
                }
            }
            Console.WriteLine($"No hay más bicis del tipo {tipoBici}");
            return false; // No hay bicis disponibles
        }
    }
}
