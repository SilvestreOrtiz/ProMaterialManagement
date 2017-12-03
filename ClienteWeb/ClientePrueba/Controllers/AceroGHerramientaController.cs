using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientePrueba.Controllers
{
    public class AceroGHerramientaController : Controller
    {
        Cliente.ClienteMaterialesGH C = new Cliente.ClienteMaterialesGH();
        //Controladores
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Consultar()
        {
            ViewBag.acerogh = C.verTodos();
            return View();
        }
        public ActionResult ListM()
        {
            ViewBag.acerogh = C.verTodos();
            return View();
        }

        public ActionResult Edit(int id_acerogh)
        {

            string ID = id_acerogh.ToString();
            ViewBag.acccerogh = C.encontrarUno(ID);
            return View(C.encontrarUno(ID));
        }
        public void Delete(int id_acerogh)
        {
            string ID = id_acerogh.ToString();
            MaterialAceroGH.AceroGHerramienta acerogh = C.encontrarUno(ID);
            C.eliminar(acerogh);
            RedirectToAction("Consultar", "AceroGHerramienta");
        }
        [HttpPost]
        public RedirectToRouteResult subir(MaterialAceroGH.AceroGHerramienta l)
        {
            C.subir(l);
            return RedirectToAction("Consultar", "AceroGHerramienta");
            TempData["msg"] = "<script>alert('El servicio fue agregado correctamente');</script>";

        }

        public RedirectToRouteResult Editar(MaterialAceroGH.AceroGHerramienta l)
        {
            C.editar(l);
            return RedirectToAction("Consultar", "AceroGHerramienta");
        }


    }
}
