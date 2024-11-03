using System.Xml.Linq;

namespace XML
{
    public class XmlConverter
    {
        public static string CrearSolicitudReservaXML(string tipoBici)
        {
            XElement solicitud = new XElement("Solicitud",
             new XElement("tipoBici", tipoBici)
            );
            return solicitud.ToString();
        }
        public class SolicitudReserva
        {
            public string TipoBici { get; set; }
        }

        public static SolicitudReserva LeerSolicitudReservaXML(string mensajeXML)
        {
            XElement solicitud = XElement.Parse(mensajeXML);
            string tipoBici = solicitud.Element("tipoBici").Value;

            return new SolicitudReserva { TipoBici = tipoBici };
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
