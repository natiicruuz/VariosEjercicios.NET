using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using XML;
using Servidor;

namespace Cliente
{
    public partial class ReservasAsientoFrm : Form
    {
        public ReservasAsientoFrm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ventanaChBx.Checked)
            {
                pasilloChBx.Checked = false;
            }
        }

        private void pasillo_CheckedChanged(object sender, EventArgs e)
        {
            if (pasilloChBx.Checked)
            {
                ventanaChBx.Checked = false;
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoAsiento = ventanaChBx.Checked ? "VENTANA" : "PASILLO";
                string nombreUsuario = usuarioTextBox.Text;

                // Genera el mensaje XML
                string mensajeXML = XMLHelper.CrearSolicitudReservaXML(nombreUsuario, tipoAsiento);

                // Envía el mensaje al servidor
                string respuesta = EnviarMensajeAlServidor(mensajeXML);

                // Muestra la respuesta en la caja de texto
                respuestaTextBox.Text = respuesta;
                // <Respuesta> < Exito > True </ Exito > </ Respuesta >
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

        private void usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void statusTxtBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
