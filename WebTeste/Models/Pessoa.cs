using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTeste.Models
{

    public class Pessoa
    {
        public Pessoa(){
            
        }

        [Required]
        [MinLength(4)]
        [Display( Name = "Nome")]
        public string Nome {get; set;}

        [Display( Name = "CPF")]
        public string CPF {get; set;}    
    }
}
