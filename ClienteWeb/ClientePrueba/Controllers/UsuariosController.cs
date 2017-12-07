using ClienteWeb.CUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientePrueba.Controllers
{
    public class UsuariosController : Controller
    {

        Cliente.ClienteUsuarios CU = new Cliente.ClienteUsuarios();
        Cliente.ClienteSesion CS = new Cliente.ClienteSesion();
        // GET: Usuario
        public ActionResult Index()
        {
            ViewBag.usuario = CU.verTodos();
            return View();
        }
        public ActionResult Agregar()
        {

            return View();
        }
        public RedirectToRouteResult Delete(int id)
        {
            string ID = id.ToString();
            Usuario usuario = CU.encontrarUno(ID);
            eliminar(usuario);
            TempData["msg"] = "<script>alert('El usuario: " + usuario.Nombre + " ha sido Eliminado');</script>";
            return RedirectToAction("Index", "Usuarios");
        }
        
        public ActionResult Edit(int id)
        {
           
                    string ID = id.ToString();

                    return View(CU.encontrarUno(ID));
                
        }


        public RedirectToRouteResult subir(Usuario usuario)
        {
            Usuario user = CS.TraerPorCorreo(usuario.Email);
            if (user.Email != null)
            {
                TempData["msg"] = "<script>alert('El correo ya esta siendo utilizado');</script>";
            }
            else
            {
                Random r = new Random();
                int azar = r.Next(1000, 9999);
                usuario.Clave = azar.ToString();
                usuario.Tipo = "normal";
                CU.subir(usuario);
                TempData["msg"] = "<script>alert('Registrado con exito');</script>";
            }

            return RedirectToAction("Index", "Usuarios");
        }


        //Agrega una fila a la tabla
        public void eliminar(ClienteWeb.CUsuarios.Usuario usuario)
        {
            CU.eliminar(usuario);
            RedirectToAction("Index", "Usuarios");

        }
        //Agrega una fila a la tabla
        public RedirectToRouteResult editar(ClienteWeb.CUsuarios.Usuario usuario)
        {

            CU.editar(usuario);
            TempData["msg"] = "<script>alert('El usuario: " + usuario.Nombre  + " ha sido Editado');</script>";
            return RedirectToAction("Index", "Usuarios");
        }
    }
}
