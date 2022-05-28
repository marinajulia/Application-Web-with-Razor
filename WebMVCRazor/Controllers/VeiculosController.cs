﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCRazor.Models;

namespace WebMVCRazor.Controllers
{
    public class VeiculosController : Controller
    {
        public ActionResult Veiculos()
        {
            ViewBag.Title = "Veículos";
            ViewBag.Message = "Cadastro de veículos";
            return View();
        }

        [HttpPost]
        public void Salvar()
        {
            var veiculo = new Veiculos();
            veiculo.Nome = Request["nome"];
            veiculo.Modelo = Request["modelo"];
            veiculo.Ano = Convert.ToInt16(Request["fabricacao"]);
            veiculo.Fabricacao = Convert.ToInt16(Request["fabricacao"]);
            veiculo.Cor = Request["cor"];
            veiculo.Combustivel = Convert.ToByte(Request["combustivel"]);
            veiculo.Automatico = false;
            veiculo.Valor = Convert.ToDecimal(Request["valor"]);
            veiculo.Ativo = true;

            veiculo.Salvar();

            Response.Redirect("/Home/About");
        }
    }
}