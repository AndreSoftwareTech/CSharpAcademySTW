using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.ManipulandoOperadores
{
    internal class ProfixPrefix
    {
        public void Executar()
        {
            int x = 5;
            int y = 10;

            int resultado1 = x++; // Profix incremento (resultado1 é 5, depois x é 6).
            int resultado2 = ++y; // Prefix incremento (y é 11, depois resultado2 é 11).

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
        }
    }
}
