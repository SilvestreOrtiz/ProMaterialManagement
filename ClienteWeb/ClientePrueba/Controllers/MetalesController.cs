using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientePrueba.Controllers
{
    public class MetalesController : Controller
    {
        Cliente.ClienteMaterialMetal C = new Cliente.ClienteMaterialMetal();
        //Controladores
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Consultar()
        {
            ViewBag.metales = C.verTodos();
            return View();
        }
        public ActionResult ListM()
        {
            ViewBag.metales = C.verTodos();
            return View();
        }

        public ActionResult Edit(int id_metal)
        {

            string ID = id_metal.ToString();
            ViewBag.acccerogm = C.encontrarUno(ID);
            return View(C.encontrarUno(ID));
        }
        public void Delete(int id_metal)
        {
            string ID = id_metal.ToString();
            MaterialMetales.Metales metales = C.encontrarUno(ID);
            C.eliminar(metales);
            RedirectToAction("Consultar", "Metales");
        }
        [HttpPost]
        public RedirectToRouteResult subir(MaterialMetales.Metales l)
        {
            C.subir(l);
            return RedirectToAction("Consultar", "Metales");
            TempData["msg"] = "<script>alert('El servicio fue agregado correctamente');</script>";

        }

        public RedirectToRouteResult Editar(MaterialMetales.Metales l)
        {
            C.editar(l);
            return RedirectToAction("Consultar", "Metales");
        }


    }
}
