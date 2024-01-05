using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.estrutura
{
    internal struct Conta
    {
        public int Id;
        public string Name;
        public decimal Saldo;

        internal decimal Deposita(decimal valor)
        {
            this.Saldo += valor;
            return this.Saldo;

        }
        public override string ToString()
        {
            return $"ID {Id}\nNome {Name}\nSaldo{Saldo}";
        }
    }
}
