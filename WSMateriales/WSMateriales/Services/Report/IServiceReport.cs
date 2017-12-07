using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WSMateriales.Entidades;

namespace WSMateriales.Services.Report
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceReport" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceReport
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool Insertar(Reporte reporte);
        [OperationContract]
        [WebInvoke(UriTemplate = "edit", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT")]
        void Editar(Reporte reporte);
        [OperationContract]
        [WebInvoke(UriTemplate = "delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        bool Eliminar(Reporte reporte);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        List<Reporte> ConsultarTodos();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "get/{idReporte}", ResponseFormat = WebMessageFormat.Json)]
        Reporte ConsultarPorId(string idReporte);
        
    }
}
