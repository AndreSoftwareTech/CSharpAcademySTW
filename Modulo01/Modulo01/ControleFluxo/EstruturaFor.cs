using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.ControleFluxo
{
    public class EstruturaFor
    {
        public void ExecutarFor()
        {
            //Incremento
            Console.WriteLine("Contagem de 1 a 5:");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Fim da contagem.");

            //Decremento
            Console.WriteLine("Contagem regressiva de 10 até 0:");

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Fim da contagem.");

            //Incremento de cinco em cinco
            Console.WriteLine("Contagem de 0 até 100 de 5 em 5:");

            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Fim da contagem.");
        }
    }
}
