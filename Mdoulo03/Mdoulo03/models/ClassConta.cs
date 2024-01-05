using Modulo03.estrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.models
{

    //1414
    internal  abstract class ClassConta
    {
        private static int _id;
        public int Id { get; private set; }
        public int NumeroAgencia { get; set; }
        public decimal Saldo { get; set; }
        public string Titular { get; set; }

        //Virtual aponta que determinado metodo pode ser sobreescrito
        public ClassConta() 
        {
            this.Id = ++_id;
        }
        public  virtual void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }

        public virtual decimal Sacar(decimal valor)
        {
            this.Saldo -= valor;
            return this.Saldo;
        }
        //Inversao de valores
        public virtual bool Transferir(decimal valor, ClassConta destino) 
        {
            if(this.Saldo < valor) 
            {
                return false;
            }
            else
            {
                this.Saldo -= valor;
                destino.Saldo += valor;
                return true;
            }
        }
        public override string ToString()
        {
            return $"ID : {this.Id}\n Titular {this.Titular}\n Saldo {this.Saldo}";
        }
    }
}
