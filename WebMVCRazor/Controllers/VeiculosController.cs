using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCRazor.Models;

namespace WebMVCRazor.Controllers
{
    public class VeiculosController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Veículos";
            ViewBag.Message = "Cadastro de carros";
            return View();
        }
    }
}