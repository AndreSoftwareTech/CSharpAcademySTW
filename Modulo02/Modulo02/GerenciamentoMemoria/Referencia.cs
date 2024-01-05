using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.GerenciamentoMemoria;

internal class Referencia
{
    

    static void Incremento(ref int value)
    {
        value++;
    }

    static void Main()
    {
        int num = 5;
        Incremento(ref num);
        Console.WriteLine(num); // Exibe 6
    }
}

