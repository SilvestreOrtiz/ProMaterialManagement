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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMaterialMetal" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMaterialMetal
    {
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        List<Metales> BuscarTodos();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "get/{id_metal}", ResponseFormat = WebMessageFormat.Json)]
        Metales BucarId(String id_metal);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json)]
        bool Create(Metales metales);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json)]
        void Edit(Metales metales);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json)]
        bool Delete(Metales metales);
    }
}
