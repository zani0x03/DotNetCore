using System.Collections.Generic;
using PessoaAPI.Models;
using PessoaAPI.Dados;

namespace PessoaAPI.BLL
{

    public class BPessoa
    {
        public List<Pessoa> RetornarPessoas(){
            return new DAOPessoa().RetornarPessoas();
        }        
    }
}