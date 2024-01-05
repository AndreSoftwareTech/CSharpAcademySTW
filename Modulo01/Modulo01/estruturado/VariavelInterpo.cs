using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.estruturado;

public class VariavelInterpo
{
    public void ExecutarVarInter() 
    {
        Console.WriteLine("Por favor, insira as informações da pessoa:");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        byte idade = Convert.ToByte(Console.Read());

        Console.Write("Gênero: ");
        string genero = Console.ReadLine();

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Profissão: ");
        string profissao = Console.ReadLine();

        Console.Write("Hobby: ");
        string hobby = Console.ReadLine();

        // Concatenando as informações em uma mensagem
        string mensagem = $"Aqui estão as informações da pessoa:\n" +
                          $"Nome: {nome}\n" +
                          $"Idade: {idade}\n" +
                          $"Gênero: {genero}\n" +
                          $"Cidade: {cidade}\n" +
                          $"Profissão: {profissao}\n" +
                          $"Hobby: {hobby}";

        Console.WriteLine(mensagem);

        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();

    }
}
