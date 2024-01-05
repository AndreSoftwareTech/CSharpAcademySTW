using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.ManipulandoOperadores
{
    internal class NameOf
    {
        public void Executar()
        {
            string nome = "Alice";
            Console.WriteLine(nameof(nome)); // Exibe "nome".

            string minhaVariavel = "Exemplo";
            string nomeDaVariavel = nameof(minhaVariavel);

            Console.WriteLine(nomeDaVariavel); // Isso exibirá "minhaVariavel".


        }


    }
}
