using ClientePrueba.WSReporte;
using ClienteWeb.MaterialAceroGM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace ClientePrueba.Cliente
{
    public class ClienteReports
    {

        //Cliente crud para recibir parametros y enviar
        //instancia de cliente
        private string BASE_URL = "http://localhost:58433/Services/Report/ServiceReport.svc/";

        //Consulta todos los materiales dentro de la tabla
        public List<Reporte> verTodos()
        {
            var synClient = new WebClient();
            var content = synClient.DownloadString(BASE_URL + "getAll");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Reporte>>(content);

        }

        //Agrega una fila a la tabla
        public void subir(ClientePrueba.WSReporte.Reporte reporte)
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ClientePrueba.WSReporte.Reporte));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, reporte);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "create", "POST", data);


        }

        //Consulta un registro
        public ClientePrueba.WSReporte.Reporte encontrarUno(string idReporte)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "get/{0}", idReporte);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<ClientePrueba.WSReporte.Reporte>(content);

        }

        //Elimina una fila a la tabla
        public void eliminar(ClientePrueba.WSReporte.Reporte reporte)
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ClientePrueba.WSReporte.Reporte));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, reporte);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "delete", "DELETE", data);

        }


    }

}