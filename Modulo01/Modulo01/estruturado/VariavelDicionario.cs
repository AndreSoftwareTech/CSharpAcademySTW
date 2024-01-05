using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.estruturado;

public class VariavelDicionario
{
    public void ExecutarDicionario()
    {
        Console.Write("Digite a idade de Andre");
        int idade1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade de Vitor");
        int idade2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade de Bob");
        int idade3 = int.Parse(Console.ReadLine());

        // Criando um dicionário com pares chave-valor
        Dictionary<string, int> idades = new Dictionary<string, int>
        {
            { "Andre", idade1 },
            { "Vitor", idade2 },
            { "Bob", idade3 }
        };

        //foreach (var kvp in idades)
        //{
        //    Console.WriteLine($"Nome: {kvp.Key}, Idade: {kvp.Value}");
        //}

        // Acessando valores no dicionário
        Console.WriteLine("Idade de Bob: " + idades["Bob"]);
        Console.WriteLine("Idade de Vitor: " + idades["Vitor"]);
        Console.WriteLine("Idade de Andre: " + idades["Andre"]);
    }
}
