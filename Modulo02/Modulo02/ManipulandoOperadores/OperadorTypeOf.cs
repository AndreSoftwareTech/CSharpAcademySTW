using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.ManipulandoOperadores
{
    internal class OperadorTypeOf
    {
        //operador type of e um operador que valida o tipo da variavel
        public void Executar()
        {
            int numero = 42;

            if (numero is int)
            {
                Console.WriteLine("É um inteiro.");
            }

            string minhaString = "Olá, Mundo!";
            Type tipo = typeof(int);
            

            Console.WriteLine("O tipo da variável minhaString é: " + tipo.Name);

        }

    }
}
