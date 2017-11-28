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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMaterialAceroInoxi" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMaterialAceroInoxi
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        List<AceroInoxidable> BuscarTodos();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "get/{idMaterial}", ResponseFormat = WebMessageFormat.Json)]
        AceroInoxidable BucarId(String idMaterial);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json)]
        bool Create(AceroInoxidable aceroinox);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json)]
        void Edit(AceroInoxidable aceroinox);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json)]
        bool Delete(AceroInoxidable aceroinox);
    }
}

