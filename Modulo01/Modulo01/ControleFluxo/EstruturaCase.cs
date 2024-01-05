using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.ControleFluxo
{
    public class EstruturaCase
    {
        public void ExecutarCase()
        {
            Console.WriteLine("Digite um número de 1 a 3:");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Você digitou o número 1.");
                    break; // O "break" encerra o bloco do case.

                case 2:
                    Console.WriteLine("Você digitou o número 2.");
                    break;

                case 3:
                    Console.WriteLine("Você digitou o número 3.");
                    break;

                default:
                    Console.WriteLine("Número fora do intervalo de 1 a 3.");
                    break;
            }

            Console.WriteLine("Fim do programa.");
        }
    }
}
