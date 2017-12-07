using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace ClientePrueba.Cliente
{
    public class ClienteSesion
    {

        
        public ClienteWeb.CUsuarios.Usuario TraerPorCorreo(string email)
        {
            string BASE = "http://localhost:58433/Services/Seguridad/ServicioLogin.svc/";
            var synClient = new WebClient();
            string url = string.Format(BASE + "pormail/{0}", email);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<ClienteWeb.CUsuarios.Usuario>(content);
        }
    }
}