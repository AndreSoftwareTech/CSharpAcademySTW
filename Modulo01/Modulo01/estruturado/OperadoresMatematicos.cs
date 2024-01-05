using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.estruturado;

public class OperadoresMatematicos
{
    public void ExecutarOpMAt()
    {
        int numero1 = 10;
        int numero2 = 5;

        // Adição
        int soma = numero1 + numero2;
        Console.WriteLine($"Soma: {soma}");

        // Subtração
        int subtracao = numero1 - numero2;
        Console.WriteLine($"Subtração: {subtracao}");

        // Multiplicação
        int multiplicacao = numero1 * numero2;
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        // Divisão (note que estamos usando float para ter um resultado decimal)
        float divisao = (float)numero1 / numero2;
        Console.WriteLine($"Divisão: {divisao}");

        // Módulo (resto da divisão)
        int modulo = numero1 % numero2;
        Console.WriteLine($"Módulo: {modulo}");

        // Incremento e Decremento
        int contador = 0;
        contador++; // Incrementa
        Console.WriteLine($"Incremento: {contador}");
        contador--; // Decrementa
        Console.WriteLine($"Decremento: {contador}");
    }
}
