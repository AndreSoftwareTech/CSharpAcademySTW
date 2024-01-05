using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.Coleções
{
    internal class CopiandoArray
    {
        public void Executar()
        {   //Array de inteiros
            //     indice    0, 1, 2  
            int[] origem = { 1, 2, 3, 4, 5, 6, 7 ,8 };
            //     indice    0, 1, 2 
            int[] destino = new int[3];

            Array.Copy(origem, destino, 3); // Copiando os elementos da origem para o destino

            //Array de nomes
            string[] nomes = { "Andre", "Rai", "Rose", "Leo", "Joni" };

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome); // Iterando e exibindo os elementos
                Console.WriteLine("Proximo Nome \n");
            }
        }
    }
}
