using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCRazor.Models;

namespace WebMVCRazor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Vende-se";
            ViewBag.Message = "Relação de carros";

            var lista = Carros.GetCarros();
            ViewBag.Lista = lista;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Seus contatos";

            return View();
        }
    }
}