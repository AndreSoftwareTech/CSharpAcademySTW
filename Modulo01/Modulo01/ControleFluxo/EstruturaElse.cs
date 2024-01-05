using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.ControleFluxo
{
    public class EstruturaElse
    {
        public void ExecutarIf()
        {
            Console.Write("Digite um número de 1 a 5: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Você digitou o número 1.");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Você digitou o número 2.");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Você digitou o número 3.");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Você digitou o número 4.");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Você digitou o número 5.");
            }
            else
            {
                Console.WriteLine("Número fora do intervalo de 1 a 5.");
            }
        }
    }
}
