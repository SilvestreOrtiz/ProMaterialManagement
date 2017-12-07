using ClienteWeb.MaterialAceroGM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;

namespace ClientePrueba.Controllers
{
    public class AceroGMaquinariaController : Controller
    {
        Cliente.ClienteDeMaterialAGM C = new Cliente.ClienteDeMaterialAGM();
        //Controladores
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Consultar()
        {
            ViewBag.acerogm = C.verTodos();
            return View();
        }
        public ActionResult ListM()
        {
            ViewBag.acerogm = C.verTodos();
            return View();
        }



        public ActionResult Edit(int id_acerogm)
        {

            string ID = id_acerogm.ToString();
            ViewBag.acccerogm = C.encontrarUno(ID);
            return View(C.encontrarUno(ID));
        }
        public void Delete(int id_acerogm)
        {
            string ID = id_acerogm.ToString();
            ClienteWeb.MaterialAceroGM.AceroGMaquinaria acerogm = C.encontrarUno(ID);
            C.eliminar(acerogm);
            RedirectToAction("Consultar", "AceroGMaquinaria");
        }
        [HttpPost]
        public RedirectToRouteResult subir(ClienteWeb.MaterialAceroGM.AceroGMaquinaria l)
        {
            C.subir(l);
            return RedirectToAction("Consultar", "AceroGMaquinaria");
            TempData["msg"] = "<script>alert('El servicio fue agregado correctamente');</script>";

        }

        public RedirectToRouteResult Editar(ClienteWeb.MaterialAceroGM.AceroGMaquinaria l)
        {
            C.editar(l);
            return RedirectToAction("Consultar", "AceroGMaquinaria");
        }


    }
}