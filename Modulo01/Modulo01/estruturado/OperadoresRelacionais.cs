using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.estruturado;

public class OperadoresRelacionais
{
    public void ExecutarOpRela()
    {
        int numero1 = 10;
        int numero2 = 5;

        // Operador "maior que"
        bool maiorQue = numero1 > numero2;
        Console.WriteLine($"Número1 é maior que número2: {maiorQue}");

        // Operador "menor que"
        bool menorQue = numero1 < numero2;
        Console.WriteLine($"Número1 é menor que número2: {menorQue}");

        // Operador "maior ou igual a"
        bool maiorOuIgual = numero1 >= numero2;
        Console.WriteLine($"Número1 é maior ou igual a número2: {maiorOuIgual}");

        // Operador "menor ou igual a"
        bool menorOuIgual = numero1 <= numero2;
        Console.WriteLine($"Número1 é menor ou igual a número2: {menorOuIgual}");

        // Operador "igual a"
        bool igual = numero1 == numero2;
        Console.WriteLine($"Número1 é igual a número2: {igual}");

        // Operador "diferente de"
        bool diferente = numero1 != numero2;
        Console.WriteLine($"Número1 é diferente de número2: {diferente}");
    }
}
