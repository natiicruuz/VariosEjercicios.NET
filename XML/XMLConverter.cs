using System.Xml.Linq;

namespace XML
{
    public class XMLConverter
    {
        public static string CrearSolicitudReservaXML(string nombreComprador, bool tieneCargador)
        {
            XElement solicitud = new XElement("PeticionReservaPlaza",
                new XElement("Comprador", nombreComprador),
                new XElement("TieneCargador", tieneCargador.ToString())
            );
            return solicitud.ToString();
        }

        public class SolicitudReserva
        {
            public string NombreComprador { get; set; }
            public bool TieneCargador { get; set; }
        }

        public static SolicitudReserva LeerSolicitudReservaXML(string mensajeXML)
        {
            XElement solicitud = XElement.Parse(mensajeXML);
            string nombreComprador = solicitud.Element("Comprador").Value;
            bool tieneCargador = bool.Parse(solicitud.Element("TieneCargador").Value);

            return new SolicitudReserva
            {
                NombreComprador = nombreComprador,
                TieneCargador = tieneCargador
            };
        }

        public static string CrearRespuestaReservaXML(int codigo, string mensaje, int numeroPlaza)
        {
            XElement respuesta = new XElement("RespuestaReservaPlaza",
                new XElement("Codigo", codigo),
                new XElement("Mensaje", mensaje),
                new XElement("NumPlazaAsignada", numeroPlaza)
            );
            return respuesta.ToString();
        }
    }
}
