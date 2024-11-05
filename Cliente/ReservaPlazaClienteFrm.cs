using System.Net.Sockets;
using System.Text;
using System.Xml;
using XML;

namespace Cliente
{
    public partial class ReservaPlazaClienteFrm : Form
    {
        public ReservaPlazaClienteFrm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el XML de solicitud
                string nombreComprador = txtNombreComprador.Text;
                bool tieneCargador = chkCargador.Checked;
                string solicitudXml = XMLConverter.CrearSolicitudReservaXML(nombreComprador, tieneCargador);

                // Conectar con el servidor
                using (TcpClient client = new TcpClient("127.0.0.1", 5000))
                using (NetworkStream stream = client.GetStream())
                {
                    // Enviar la solicitud al servidor
                    byte[] dataToSend = Encoding.UTF8.GetBytes(solicitudXml);
                    stream.Write(dataToSend, 0, dataToSend.Length);

                    // Recibir la respuesta del servidor
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string respuestaXml = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Procesar la respuesta
                    ProcesarRespuestaXml(respuestaXml);
                }
            }
            catch (Exception ex)
            {
                txtBxError.Text = "Error: " + ex.Message;
            }
        }

        private void ProcesarRespuestaXml(string respuestaXml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(respuestaXml);

            XmlNode respuestaNode = doc.SelectSingleNode("/RespuestaReservaPlaza");

            if (respuestaNode != null)
            {
                XmlNode numPlazaNode = respuestaNode.SelectSingleNode("NumPlazaAsignada");
                XmlNode mensajeNode = respuestaNode.SelectSingleNode("Mensaje");

                if (numPlazaNode != null && int.TryParse(numPlazaNode.InnerText, out int numeroPlaza) && numeroPlaza > 0)
                {
                    txtBxPlazaAsignada.Text = numeroPlaza.ToString();
                    txtBxError.Text = "";
                }
                else if (mensajeNode != null)
                {
                    txtBxPlazaAsignada.Text = "";
                    txtBxError.Text = mensajeNode.InnerText;
                }
            }

        }
        private void ReservaPlazaClienteFrm_Load(object sender, EventArgs e)
        {

        }
        private void txtNumPlaza_Click(object sender, EventArgs e)
        {
        }
    }
}
