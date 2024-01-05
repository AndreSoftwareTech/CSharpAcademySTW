using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.estruturado;

public class VariavelTupla
{
    public void ExecutarVarTupla()
    {
        // Criando uma tupla
        var pessoa = (nome: "Andre", idade: 26, cidade: "Blumenau");

        // Acessando elementos da tupla
        string nomeDaPessoa     = pessoa.nome;
        int idadeDaPessoa       = pessoa.idade;
        string cidadeDaPessoa   = pessoa.cidade;

        // Exibindo informações da tupla
        Console.WriteLine($"Nome: {nomeDaPessoa}");
        Console.WriteLine($"Idade: {idadeDaPessoa}");
        Console.WriteLine($"Cidade: {cidadeDaPessoa}");

        // Modificando elementos da tupla
        pessoa = (nome: "Bob", idade: 30, cidade: "Barra Velha");

        // Exibindo informações da tupla após a modificação
        Console.WriteLine("\nApós a modificação:");
        Console.WriteLine($"Nome: {pessoa.nome}");
        Console.WriteLine($"Idade: {pessoa.idade}");
        Console.WriteLine($"Cidade: {pessoa.cidade}");

        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
}
