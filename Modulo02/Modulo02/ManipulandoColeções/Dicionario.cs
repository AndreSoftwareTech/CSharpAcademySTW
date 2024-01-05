using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.Coleções
{
    internal class Dicionario
    {
        public void Executar()
        {
            //Classe interna 
            Dictionary<string, int> idades = new Dictionary<string, int>();
            idades["Alice"] = 25;               // Adicionando um par chave-valor ao dicionário
            idades["Bob"] = 30;
            idades["Jesus"] = 2023;
            int idadeAlice = idades["Alice"]; // Acessando o valor por chave

            Console.WriteLine(idades["Jesus"]);
        }
    }
}
