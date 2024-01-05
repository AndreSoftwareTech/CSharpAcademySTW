using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.GerenciamentoMemoria;

internal class Conversao
{
    //Conversao implicita e explicita
    public void Executar()
    {
        int num = 10;
        double result = num; // Conversão implícita de int para double
        Console.WriteLine(result); // Exibe 10.0

        double num2 = 20.5;
        int integerNum = (int)num2; // Conversão explícita de double para int
        Console.WriteLine(integerNum); // Exibe 20
    }

}
