using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSMateriales.Entidades;

namespace WSMateriales.Services.CRUD
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AddUser" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AddUser.svc o AddUser.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AddUser : IAddUser
    {
        DataMasterEntities Mydata = new DataMasterEntities();
        public Usuario ConsultarPorId(string id)
        {
            Usuario user = new Usuario();
            int ID = int.Parse(id);
            var Query = from usuario in Mydata.Usuario
                        where usuario.Id == ID
                        select usuario;

            foreach (var result in Query)
            {
                user = result;
            }

            return user;
        }

        public List<Usuario> ConsultarPorMail(string email)
        {
            List<Usuario> lista = new List<Usuario>();

            var Query = from usuario in Mydata.Usuario
                        where usuario.Email == email
                        select usuario;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            Console.WriteLine("Resultado " + lista.First());
            return lista;
        }

        public List<Usuario> ConsultarTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            var Query = from usuario in Mydata.Usuario
                        select usuario;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            Console.WriteLine("Resultado " + lista.First());
            return lista;
        }

        public bool DeleteUser(Usuario user)
        {
            Usuario usuario = Mydata.Usuario.Find(user.Id);
            Mydata.Usuario.Remove(usuario);
            Mydata.SaveChanges();
            return true;
        }

        public void EditUser(Usuario user)
        {
            var users = Mydata.Usuario.FirstOrDefault(x => x.Id == user.Id);

            user.Nombre = users.Nombre;
            user.Password = users.Password;
            user.Telefono = users.Telefono;
            user.Telefono = users.Tipo;
            user.Email = users.Email;
            Mydata.SaveChanges();
        }

        public bool NewUser(Usuario user)
        {
            Mydata.Usuario.Add(user);
            Mydata.SaveChanges();
            return true;
        }
    }
}
