using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.ManipulandoOperadores.Relacionais
{
    internal class Logicos
    {
        public void Executar()
        {
            bool a = true;
            bool b = false;
            bool resultado = a && b; // AND lógico  // os dois lados tem que ser verdadeiro para o resultado ser verdadeiro
            bool resultado2 = a || b; // OR lógico // se um dos lados for verdade, o resultado é verdade
            bool resultado3 = !a; // NOT lógico  // inverte o valor, se for verdade transforma em falso

            //operador ternario
            bool res = !(a && b); // (true e false) = false,  mas com a negacao o resultado se torna true
        }



    }
}
