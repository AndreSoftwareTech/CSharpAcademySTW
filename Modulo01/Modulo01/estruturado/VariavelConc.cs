using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.estruturado;

public class VariavelConc
{
    public void ExecutarVarConc() 
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
        string mensagem = "Aqui estão as informações da pessoa:\n" +
                          "Nome: "      +   nome    +
                          "Idade: "     +   idade   +
                          "Gênero: "    +   genero  +
                          "Cidade: "    +   cidade  +
                          "Profissão: " +   profissao +
                          "Hobby: "     +   hobby;

        Console.WriteLine(mensagem);

        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();

    }
}
