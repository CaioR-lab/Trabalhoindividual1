using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Models
{
    public class ClassePessoaJuridica : ClassePessoa
    {
        public string CNPJ { get; set; }
        public ClasseEndereco Endereco { get; set; }
    }
}
