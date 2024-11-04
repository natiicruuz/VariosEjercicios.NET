using System.Xml.Linq;

namespace XML
{
    public class XMLConverter
    {
        public static string CrearSolicitudReservaXML(string tipoReserva)
        {
            XElement solicitud = new XElement("Solicitud",
                new XElement("TipoReserva", tipoReserva)
            );
            return solicitud.ToString();
        }

        public class SolicitudReserva
        {
            public string TipoReserva { get; set; }
        }

        public static SolicitudReserva LeerSolicitudReservaXML(string mensajeXML)
        {
            XElement solicitud = XElement.Parse(mensajeXML);
            string tipoReserva = solicitud.Element("TipoReserva").Value;

            return new SolicitudReserva { TipoReserva = tipoReserva };
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