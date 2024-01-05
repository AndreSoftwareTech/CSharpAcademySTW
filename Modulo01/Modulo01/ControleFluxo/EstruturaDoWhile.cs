using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.ControleFluxo
{
    public class EstruturaDoWhile
    {
        public void ExecutarDoWhile()
        {
            int numero;

            do
            {
                Console.Write("Digite um número maior que 5: ");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 5)
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }

            } while (numero <= 5);

            Console.WriteLine($"Você digitou {numero}, que é maior que 5. Parabéns!");
        }
    }
}
