using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.Coleções
{
    internal class IterandoArray
    {
        public void Executar()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero); // Iterando e exibindo os elementos
            }

        }
    }
}
