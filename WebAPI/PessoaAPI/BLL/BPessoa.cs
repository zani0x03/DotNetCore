using System.Collections.Generic;
using PessoaAPI.Models;
using PessoaAPI.DAL;

namespace PessoaAPI.BLL
{

    public class BPessoa
    {
        public List<Pessoa> RetornarPessoas(){
            return new DAOPessoa().RetornarPessoas();
        }        
    }
}