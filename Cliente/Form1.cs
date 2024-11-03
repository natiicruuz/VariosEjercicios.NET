using System.Net.Sockets;
using System.Text;
using XML;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoAsiento = ElectricBikeChBx.Checked ? "ELECTRIC" : "NORMAL";

                // Genera el mensaje XML
                string mensajeXML = XmlConverter.CrearSolicitudReservaXML(tipoAsiento);

                // Envía el mensaje al servidor
                string respuesta = EnviarMensajeAlServidor(mensajeXML);

                // Muestra la respuesta en la caja de texto
                statusResponseTxt.Text = respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar la disponibilidad: {ex.Message}");
            }
        }

        private static string EnviarMensajeAlServidor(string mensajeXML)
        {
            try
            {
                // Conectar al servidor en localhost y puerto 5000
                using (TcpClient client = new TcpClient("127.0.0.1", 5000))
                using (NetworkStream stream = client.GetStream())
                {
                    // Convertir el mensaje XML a bytes y enviarlo al servidor
                    byte[] mensajeBytes = Encoding.UTF8.GetBytes(mensajeXML);
                    stream.Write(mensajeBytes, 0, mensajeBytes.Length);

                    // Recibir la respuesta del servidor
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string respuestaXML = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    return respuestaXML;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "Error en el envío";
            }
        }


        // permite que solo se seleccionen uno al mismo tiempo. 
        private void ElectricBikeChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (ElectricBikeChBx.Checked)
            {
                NormalBikeChBx.Checked = false;
            }
        }

        private void NormalBikeChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalBikeChBx.Checked)
            {
                ElectricBikeChBx.Checked = false;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
