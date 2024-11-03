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


        private async void AcceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoAsiento = ElectricBikeChBx.Checked ? "ELECTRIC" : "NORMAL";

                // Genera el mensaje XML
                string mensajeXML = XmlConverter.CrearSolicitudReservaXML(tipoAsiento);

                // Envía el mensaje al servidor y espera la respuesta
                string respuesta = await EnviarMensajeAlServidorAsync(mensajeXML);

                // Muestra la respuesta en la caja de texto
                statusResponseTxt.Text = respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar la disponibilidad: {ex.Message}");
            }
        }

        private static async Task<string> EnviarMensajeAlServidorAsync(string mensajeXML)
        {
            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 5000))
                using (NetworkStream stream = client.GetStream())
                {
                    // Convertir el mensaje XML a bytes y enviarlo al servidor de forma asincrónica
                    byte[] mensajeBytes = Encoding.UTF8.GetBytes(mensajeXML);
                    await stream.WriteAsync(mensajeBytes, 0, mensajeBytes.Length);

                    // Recibir la respuesta del servidor de forma asincrónica
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
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
