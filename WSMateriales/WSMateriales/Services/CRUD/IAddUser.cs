using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WSMateriales.Entidades;

namespace WSMateriales.Services.CRUD
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAddUser" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAddUser
    {

        [OperationContract]
        [WebInvoke(UriTemplate = "create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool NewUser(Usuario user);

        [WebInvoke(UriTemplate = "delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        bool DeleteUser(Usuario user);

        [WebInvoke(UriTemplate = "edit", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT")]
        void EditUser(Usuario user);

        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> ConsultarTodos();

        [OperationContract]
        List<Usuario> ConsultarPorMail(string email);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "get/{Id}", ResponseFormat = WebMessageFormat.Json)]
        Usuario ConsultarPorId(string id);

    }
}
