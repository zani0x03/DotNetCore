using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebTeste.Models;

namespace mvcTeste.Controllers{
    public class HomeController : Controller{
        public IActionResult Index(){
            return View();
        }

        public IActionResult Criar(){
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Criar(Pessoa obj){
            TempData["nome"] = obj.Nome;
            TempData["CPF"] = obj.CPF;
            return RedirectToAction("Salvar");
        }

        public IActionResult Salvar()   
        {
            var pessoa = new Pessoa();      
            pessoa.Nome = (string)TempData["nome"];
            pessoa.CPF = (string)TempData["CPF"];
            return View(pessoa);
        }
    }
}