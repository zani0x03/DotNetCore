using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using PessoaAPI.Models;

namespace PessoaAPI.Controllers
{
    public class PessoaController : Controller{
        public List<PessoaAPI.Models.Pessoa> Get(){
            List<Pessoa> list = new List<Pessoa>();

            for(int i=0; i<10;i++){
                Pessoa p = new Pessoa();
                p.CPF = string.Format("CPF{0}",i);
                p.Nome = string.Format("Nome{0}",i);
                list.Add(p);
            }

            return list;
        }
    }
}