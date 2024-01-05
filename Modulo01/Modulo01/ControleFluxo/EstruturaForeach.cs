using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.ControleFluxo
{
    public class EstruturaForeach
    {
        public void ExecutarForeach()
        {
            //Percorrendo uma lista
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Números na lista:");

            // Usando foreach para percorrer a lista e exibir os números
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Fim da lista.");

            //Percorrendo um dicionario
            Dictionary<string, int> idadePorNome = new Dictionary<string, int>
                {
                    { "Alice", 25 },
                    { "Bob", 30 },
                    { "Charlie", 22 }
                };

            foreach (var entrada in idadePorNome)
            {
                Console.WriteLine($"Nome: {entrada.Key}, Idade: {entrada.Value}");
            }

            // percorrendo caracteres de uma string
            string texto = "Exemplo de Foreach No Csharp";

            foreach (char caractere in texto)
            {
                if (char.IsUpper(caractere))
                {
                    Console.WriteLine(caractere);
                }
            }


        }
    }
}
