using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.ManipulandoOperadores
{
    internal class InvocandoFuncao
    {

        public void Executar()
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            int resultado = Somar(3, 4); // Chamando a função "Somar".

            Console.WriteLine(resultado);
        }


    }
}
