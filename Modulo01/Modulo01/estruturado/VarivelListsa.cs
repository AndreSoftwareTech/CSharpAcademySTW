using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.estruturado;

public class VarivelListsa
{
    public void ExecutarLista()
    {
        Console.Write("Digite o primeiro numero");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite oterceiro numero");
        int n3 = int.Parse(Console.ReadLine());

        List<int> numeros = new List<int>();

        // Adicionando elementos à lista
        numeros.Add(n1);
        numeros.Add(n2);
        numeros.Add(n3);

        // Acessando elementos da lista
        Console.WriteLine("Elementos da Lista:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
