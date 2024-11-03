using System.Xml.Linq;

namespace XML
{
    public static class XMLHelper
    {
        public static string CrearSolicitudReservaXML(string nombreUsuario, string tipoAsiento)
        {
            XElement solicitud = new XElement("Solicitud",
                new XElement("Usuario", nombreUsuario),
                new XElement("TipoAsiento", tipoAsiento)
            );
            return solicitud.ToString();
        }

        public static (string usuario, string tipoAsiento) LeerSolicitudReservaXML(string mensajeXML)
        {
            XElement solicitud = XElement.Parse(mensajeXML);
            string usuario = solicitud.Element("Usuario").Value;
            string tipoAsiento = solicitud.Element("TipoAsiento").Value;
            return (usuario, tipoAsiento);
        }

        public static string CrearRespuestaReservaXML(bool exito)
        {
            XElement respuesta = new XElement("Respuesta",
                new XElement("Exito", exito.ToString())
            );
            return respuesta.ToString();
        }
    }
}
