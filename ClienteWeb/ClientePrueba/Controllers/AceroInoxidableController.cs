using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientePrueba.Controllers
{
    public class AceroInoxidableController : Controller
    {
        Cliente.ClienteMaterialAceroInoxidable C = new Cliente.ClienteMaterialAceroInoxidable();
        //Controladores
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Consultar()
        {
            ViewBag.aceroinox = C.verTodos();
            return View();
        }
        public ActionResult ListM()
        {
            ViewBag.aceroinox = C.verTodos();
            return View();
        }

        public ActionResult Edit(int id_aceroInox)
        {

            string ID = id_aceroInox.ToString();
            ViewBag.acccerogm = C.encontrarUno(ID);
            return View(C.encontrarUno(ID));
        }
        public void Delete(int id_aceroInox)
        {
            string ID = id_aceroInox.ToString();
            MaterialAceroInoxidable.AceroInoxidable aceroinox = C.encontrarUno(ID);
            C.eliminar(aceroinox);
            RedirectToAction("Consultar", "AceroInoxidable");

        }
        [HttpPost]
        public RedirectToRouteResult subir(MaterialAceroInoxidable.AceroInoxidable l)
        {
            C.subir(l);
            return RedirectToAction("Consultar", "AceroInoxidable");
            TempData["msg"] = "<script>alert('El servicio fue agregado correctamente');</script>";

        }

        public RedirectToRouteResult Editar(MaterialAceroInoxidable.AceroInoxidable l)
        {
            C.editar(l);
            return RedirectToAction("Consultar", "AceroInoxidable");

        }


    }
}
