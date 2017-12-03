using ClientePrueba.CUsuarios;
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
    public class ClienteUsuarios
    {


        private string BASE_URL = "http://localhost:58433/Services/CRUD/AddUser.svc/";

        //Consulta todos los usuarios dentro de la tabla
        public List<Usuario> verTodos()
        {
            var synClient = new WebClient();
            var content = synClient.DownloadString(BASE_URL + "getAll");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Usuario>>(content);
        }
        public bool subir(Usuario usuario)
        {
            ClienteSesion CS = new ClienteSesion();
            //Encriptar password
            string password = usuario.Password;
            usuario.Password = password;
            //Agregar al usuario
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CUsuarios.Usuario));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, usuario);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "create", "POST", data);
            return true;
        }
        public CUsuarios.Usuario encontrarUno(string id)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "get/{0}", id);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<CUsuarios.Usuario>(content);

        }
        //Agrega una fila a la tabla
        public void eliminar(CUsuarios.Usuario usuario)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CUsuarios.Usuario));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, usuario);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(BASE_URL + "delete", "DELETE", data);
            }
            catch (Exception)
            {

                throw;
            }


        }
        //Agrega una fila a la tabla
        public void editar(CUsuarios.Usuario usuario)
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CUsuarios.Usuario));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, usuario);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "edit", "PUT", data);



        }
    }


}
