using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PessoaAPI.BLL;
using PessoaAPI.Models;

namespace PessoaAPI.Controllers
{
    [Route("api/[controller]")]
    public class ApiPessoaController : Controller
    {
        // GET api/values
        [HttpGet("{id}")]
        public List<PessoaAPI.Models.Pessoa> Get(){
            return new BPessoa().RetornarPessoas();
        }
        
    }
}