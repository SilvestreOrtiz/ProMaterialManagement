using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSMateriales.Entidades;

namespace WSMateriales.Services.Seguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioLogin" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioLogin.svc o ServicioLogin.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioLogin : IServicioLogin
    {
        DataMasterEntities Mydata = new DataMasterEntities();
        public Usuario BuscarPorMail(string email)
        {
            Usuario user = new Usuario();
            var Query = from usuario in Mydata.Usuario
                        where usuario.Email == email
                        select usuario;

            foreach (var result in Query)
            {
                user = result;
            }

            return user;
        }
       


        public bool Conectar(string email, string password)
        {
           
            bool correcto = false;
            Usuario user = new Usuario();
            var Query = from usuario in Mydata.Usuario
                        where usuario.Email == email
                        select usuario;

            foreach (var result in Query)
            {
                user = result;
            }
            
            if (password.Equals(user.Password))
            {
                correcto = true;
            }
            else
            {
                correcto = false;
            }
            return correcto;
        }

        public bool Desconectar()
        {
            return true;
        }
    }
}
