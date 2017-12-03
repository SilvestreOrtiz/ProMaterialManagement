using ClientePrueba.MaterialAceroGH;
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
    public class ClienteMaterialesGH
    {

        //Cliente crud para recibir parametros y enviar
        //instancia de cliente
        private string BASE_URL = "http://localhost:58433/Services/CRUD/MaterialAceroGH.svc/";

        //Consulta todos los materiales dentro de la tabla
        public List<AceroGHerramienta> verTodos()
        {
            var synClient = new WebClient();
            var content = synClient.DownloadString(BASE_URL + "getAll");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<AceroGHerramienta>>(content);

        }

        //Agrega una fila a la tabla
        public void subir(MaterialAceroGH.AceroGHerramienta acerogh)
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(MaterialAceroGH.AceroGHerramienta));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, acerogh);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "create", "POST", data);


        }

        //Consulta un registro
        public MaterialAceroGH.AceroGHerramienta encontrarUno(string id_acerogh)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "get/{0}", id_acerogh);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<MaterialAceroGH.AceroGHerramienta>(content);

        }

        //Agrega una fila a la tabla
        public void editar(MaterialAceroGH.AceroGHerramienta acerogh)
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(MaterialAceroGH.AceroGHerramienta));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, acerogh);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "edit", "PUT", data);


        }

        //Elimina una fila a la tabla
        public void eliminar(MaterialAceroGH.AceroGHerramienta acerogh)
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(MaterialAceroGH.AceroGHerramienta));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, acerogh);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "delete", "DELETE", data);

        }


    }
}
