using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.models
{
    internal class Gerenciador
    {
        public decimal TotalComissao { get; set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalComissao += funcionario.Comissao();
        }

    }
}
