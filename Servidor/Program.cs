using System.Net.Sockets;
using System.Net;
using System.Text;
using XML;

namespace Servidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Servidor arrancado!");
            ServidorAsientos.IniciarServidor();
        }
    }

    public class ServidorAsientos
    {
        private static readonly bool[] asientos = new bool[40];

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

                    var solicitud = XMLHelper.LeerSolicitudReservaXML(mensajeXML);
                    bool exito = ReservarAsiento(solicitud.tipoAsiento, solicitud.usuario);
                    string respuestaXML = XMLHelper.CrearRespuestaReservaXML(exito);

                    byte[] respuestaBytes = Encoding.UTF8.GetBytes(respuestaXML);
                    stream.Write(respuestaBytes, 0, respuestaBytes.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static bool ReservarAsiento(string tipoAsiento, string usuario)
        {
            lock (asientos)
            {
                for (int i = 0; i < asientos.Length; i++)
                {
                    if (!asientos[i])
                    {
                        asientos[i] = true;
                        Console.WriteLine($"Asiento {i} reservado como {tipoAsiento} para {usuario}");
                        return true;
                    }
                }
            }
            Console.WriteLine($"No hay mas asientos del tipo {tipoAsiento}");
            return false; // No hay asientos disponibles
        }
    }
}
