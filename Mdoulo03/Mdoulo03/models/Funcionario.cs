using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.models
{
    internal class Funcionario
    {
        public string Nome { get; set; }    
        public string Cpf { get; set; }
        public decimal Salario { get; set; }

        public  decimal Comissao()
        {
            return this.Salario * 0.10m;
        }
    }
}
