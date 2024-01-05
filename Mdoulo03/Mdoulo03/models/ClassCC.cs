using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.models
{   //1416
    internal class ClassCC : ClassConta
    {
        private int _numsaque;
        //Override indica que o metodo em questao pode sofrer alteracao de valores doque esta na mae

        public ClassCC(decimal valor): base()
        {
            
            while(valor <= 0)
            {
                Console.WriteLine("Digite um valor maior que zero");
                valor = decimal.Parse(Console.ReadLine());
            }
            this.Saldo = valor;

        }
        public override decimal Sacar(decimal valor)
        {
            this._numsaque++;



            if (this._numsaque == 10) 
            {
                this.Saldo -= 0.25m;
                this._numsaque = 0;
                return valor; 
            }
            return base.Sacar(valor);
        }

        //1414
        public override string ToString() { return base.ToString(); }
    }
}
