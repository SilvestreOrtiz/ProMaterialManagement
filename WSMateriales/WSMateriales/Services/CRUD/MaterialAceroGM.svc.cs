using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSMateriales.Entidades;

namespace WSMateriales.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MaterialAceroGM" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MaterialAceroGM.svc o MaterialAceroGM.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class MaterialAceroGM : IMaterialAceroGM
    {

        DataMasterEntities Mydata = new DataMasterEntities();

        public List<AceroGMaquinaria> ConsultarPorCalidad(string calidad)
        {
            List<AceroGMaquinaria> lista = new List<AceroGMaquinaria>();

            var Query = from acerogm in Mydata.AceroGMaquinaria
                        where  acerogm.Calidad == calidad
                        select acerogm;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            Console.WriteLine("Resultado " + lista.First());
            return lista;
        }

        public AceroGMaquinaria ConsultarPorId(string id_acerogm)
        {
            AceroGMaquinaria item = new AceroGMaquinaria();
            int ID = int.Parse(id_acerogm);
            var Query = from acerogm in Mydata.AceroGMaquinaria
                        where acerogm.id_acerogm == ID
                        select acerogm;

            foreach (var result in Query)
            {
                item = result;
            }

            return item;
        }

        public List<AceroGMaquinaria> ConsultarTodos()
        {
            List<AceroGMaquinaria> lista = new List<AceroGMaquinaria>();

            var Query = from acerogm in Mydata.AceroGMaquinaria
                        select acerogm;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            Console.WriteLine("Resultado " + lista.First());
            return lista;
        }

        public void Editar(AceroGMaquinaria acerogm)
        {
            var item = Mydata.AceroGMaquinaria.FirstOrDefault(x => x.id_acerogm == acerogm.id_acerogm);

            item.Calidad = acerogm.Calidad;
            item.Perfil = acerogm.Perfil;
            item.Acabado = acerogm.Acabado;
            item.Medidas = acerogm.Medidas;
            item.Cantidad = acerogm.Cantidad;
            Mydata.SaveChanges();
        }

        public bool Eliminar(AceroGMaquinaria acerogm)
        {
            AceroGMaquinaria mate = Mydata.AceroGMaquinaria.Find(acerogm.id_acerogm);
            Mydata.AceroGMaquinaria.Remove(mate);
            Mydata.SaveChanges();
            return true;
        }

        public bool Insertar(AceroGMaquinaria acerogm)
        {
            //Contruccion del objeto
            Mydata.AceroGMaquinaria.Add(acerogm);
            Mydata.SaveChanges();
            return true;
        }
    }
}
