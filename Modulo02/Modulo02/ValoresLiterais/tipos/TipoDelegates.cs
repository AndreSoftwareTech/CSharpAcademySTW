using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.tipos
{
    // Tipo por referencia
    internal class TipoDelegates
    {
        public void Executa()
        {
            Console.WriteLine("Delegates");
            int num = 4;
            int exp = 3;

            Console.WriteLine(new Exponenciacao().CalExponete(num, exp));
        }
    }

    internal class Exponenciacao
    {
       //Tipo por referencia
        private delegate string Expoente(int numero);

        public string CalExponete(int numero, int expoente)
        {
            Expoente exp;

            if (expoente == 2)
            {
                exp = Quadrado;
            }
            else
            {
                exp = Cubo;
            }

            return exp(numero);
        }
        private string Quadrado(int num)
        {
            int result = num * num;
            return $" O valor do quadrado de {num} é {result}";
        }
        private string Cubo(int num)
        {
            int result = num * num * num;
            return $" O valor do cubo de {num} é {result}";
        }
    }
}
