using ClientePrueba.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ClientePrueba.Controllers
{
    public class SesionController : Controller
    {
        ClienteUsuarios c = new ClienteUsuarios();
        ClienteSesion s = new ClienteSesion();
        public ActionResult Login()
        {
            return View();
        }
        public RedirectToRouteResult Logout()
        {
            if (Session["usuario"] != null)
            {
                Session["usuario"] = null;
                Session["nombre"] = null;
                Session["id"] = null;
                Session["email"] = null;
                TempData["msg"] = "<script>alert('Gracias por usar nuestros servicios');</script>";
            }
            return RedirectToAction("Login", "Sesion");
        }
        public ActionResult Registrarse()
        {
          
                return View();
            
                return RedirectToAction("Index", "Usuarios");
            
        }

        public ActionResult Recuperar()
        {
            TempData["msg"] = "<script>alert('Ingrese su Email para enviarle como puede recuperar su cuenta muy sencillo');</script>";
            return View();
        }
        public void EnviarCorreo(string email)
        {
            List<CUsuarios.Usuario> lista = c.verTodos();
            CUsuarios.Usuario usuario = null;
            foreach (var result in lista)
            {
                if (email.Equals(result.Email))
                {
                    usuario = result;
                }
            }
            string recupera = "http://localhost:58433/Services/Seguridad/ServicioLogin.svc/?Clave=" + usuario.Clave + "&id=" + usuario.Id;
            MailMessage m;
            m = new MailMessage();
            m.To.Add(new MailAddress(email));
            m.From = new MailAddress("silvestre.equisde@gmail.com");
            m.Subject = "Recuperar Contraseña";
            m.Body = "Url de recuperacion ingrese aqui para recuperar su contraseña: <a href=" + recupera + ">Recupera tu contraseña aqui</a>";
            m.IsBodyHtml = true;
            SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
            using (cliente)
            {
                cliente.Credentials = new System.Net.NetworkCredential("silvestre.equisde@gmail.com", "silverhk1236030");
                cliente.EnableSsl = true;
                cliente.Send(m);
            }
        }
        //Clientes
        private string BASE_URL = "http://localhost:58433/Services/Seguridad/ServicioLogin.svc/";

        public bool Loguear(string email, string password)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "conectar/{0},{1}", email, password);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<bool>(content);
        }
        public RedirectToRouteResult Sesion(string email, string password)
        {
            if (Loguear(email, password))
            {
                Session["usuario"] = TraerPorCorreo(email).Tipo;
                Session["nombre"] = TraerPorCorreo(email).Nombre;
                Session["id"] = TraerPorCorreo(email).Id;
                Session["email"] = TraerPorCorreo(email).Email;
                TempData["msg"] = "<script>alert('Bienvenido: " + Session["nombre"] + "');</script>";
                return RedirectToAction("Index", "Home");
            }
            else
            {

            }
            return RedirectToAction("Index", "Home");
        }
        public CUsuarios.Usuario TraerPorCorreo(string email)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "pormail/{0}", email);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<CUsuarios.Usuario>(content);
        }
        public ActionResult Recuperacion(string Clave, string id)
        {

            CUsuarios.Usuario usuario = c.encontrarUno(id);
            if (Clave.Equals(usuario.Clave))
            {
                return View(usuario);
            }
            else
            {
                TempData["msg"] = "<script>alert('Error');</script>";
                return RedirectToAction("Index", "Home");
            }

        }
        public RedirectToRouteResult cambiarPass(CUsuarios.Usuario usuario)
        {
            CUsuarios.Usuario user = c.encontrarUno(usuario.Id.ToString());
            user.Password = usuario.Password;
            c.editar(user);
            TempData["msg"] = "<script>alert('Su contraseña ha sido cambiada');</script>";
            return RedirectToAction("Index", "Home");
        }
    }
}
