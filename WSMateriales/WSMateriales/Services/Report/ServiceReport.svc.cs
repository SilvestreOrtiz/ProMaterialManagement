using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSMateriales.Entidades;

namespace WSMateriales.Services.Report
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceReport" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceReport.svc o ServiceReport.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceReport : IServiceReport
    {
        DataMasterEntities Mydata = new DataMasterEntities();

        public Reporte ConsultarPorId(string idReporte)
        {
            Reporte report = new Reporte();
            int ID = int.Parse(idReporte);
            var Query = from rp in Mydata.Reporte
                        where rp.idReport == ID
                        select rp;

            foreach (var result in Query)
            {
                report = result;
            }

            return report;
        }

        public List<Reporte> ConsultarTodos()
        {
            List<Reporte> lista = new List<Reporte>();
            var Query = from r in Mydata.Reporte
                        select r;
            foreach (var result in Query)
            {

                lista.Add(result);
            }

            return lista;
        }

        public void Editar(Reporte reporte)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Reporte reporte)
        {
            Reporte r = Mydata.Reporte.Find(reporte.idReport);
            Mydata.Reporte.Remove(r);
            Mydata.SaveChanges();
            return true;
        }

        public bool Insertar(Reporte reporte)
        {
            Mydata.Reporte.Add(reporte);
            Mydata.SaveChanges();
            return true;
        }
    }
}
