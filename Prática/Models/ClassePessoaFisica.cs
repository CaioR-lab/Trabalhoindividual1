using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratica.Models;

namespace Pratica.Models
{
    public class ClassePessoaFisica : ClassePessoa
    {

        public string CPF { get; set; }
        public string RG { get; set; }
        public ClasseEndereco Endereco { get; set; }

    }
}
