using System.Net.Sockets;
using System.Text;
using System.Xml;
using XML;

namespace Cliente
{
    public partial class ReservaFrm : Form
    {
        public ReservaFrm()
        {
            InitializeComponent();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoAsiento = conCargadorChBx.Checked ? "CONCARGADOR" : "SINCARGADOR";
                string mensajeXML = XMLConverter.CrearSolicitudReservaXML(tipoAsiento);

                // Enviar mensaje al servidor y obtener respuesta asincrónicamente
                string respuesta = EnviarMensajeAlServidor(mensajeXML);

                // Mostrar la respuesta en el formulario
                resultTxt.Text = respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar la disponibilidad: {ex.Message}");
            } 
        }

        private string EnviarMensajeAlServidor(string mensajeXML)
        {
            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 5000))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] mensajeBytes = Encoding.UTF8.GetBytes(mensajeXML);
                    stream.Write(mensajeBytes, 0, mensajeBytes.Length);

                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    return Encoding.UTF8.GetString(buffer, 0, bytesRead);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "Error en el envío";
            }
        }
  

        private void sinCargadorChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (sinCargadorChBx.Checked) { 
                conCargadorChBx.Checked = false;
            }
        }

        private void conCargadorChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (conCargadorChBx.Checked)
            {
                sinCargadorChBx.Checked = false;
            }
        }
    }
}
