using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.Coleções
{
    internal class Lista
    {

        public void Executar()
        {
            List<int> numeros = new List<int>();
            numeros.Add(10); // Adicionando um elemento à lista
            numeros.Add(20);
            int primeiroNumero = numeros[0]; // Acessando elementos por índice
            Console.WriteLine(primeiroNumero);
        }
    }
}
