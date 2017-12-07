using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientePrueba.Controllers
{
    public class ProyectosReportController : Controller
    {
        Cliente.ClienteReports C = new Cliente.ClienteReports();
        //Controladores
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Consultar()
        {
            ViewBag.reporte= C.verTodos();
            return View();
        }
       



        public void Delete(int idReporte)
        {
            string ID = idReporte.ToString();
            WSReporte.Reporte reporte = C.encontrarUno(ID);
            C.eliminar(reporte);
            RedirectToAction("Consultar", "AceroGMaquinaria");
        }
        [HttpPost]
        public RedirectToRouteResult subir(WSReporte.Reporte l)
        {
            C.subir(l);
            return RedirectToAction("Consultar", "AceroGMaquinaria");
            TempData["msg"] = "<script>alert('El servicio fue agregado correctamente');</script>";

        }

       


    }
}
