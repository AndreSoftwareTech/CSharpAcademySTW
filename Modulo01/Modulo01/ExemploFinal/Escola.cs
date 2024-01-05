using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.ExemploFinal;


public class Escola
{
    public void Main()
    {
        Console.WriteLine("Sejam bem vindos a escola de programacao Apex");
        do
        {
            string nome = ObterDado(" Nome ");
            string sobrenome = ObterDado("Sobrenome");
            byte idade = ObterIdade();

            float nota1 = ObterNota("Primeira Nota");
            float nota2 = ObterNota("Digite a Segunda Nota");
            float media = CalcularMedia(nota1, nota2);

            List<string> diciplinas = ObterDiciplinas();

            Dictionary<string, object> aluno = new Dictionary<string, object>
            {
                {"Nome", nome },
                {"SobreNome", sobrenome },
                {"Idade", idade },
                {"Nota-1", nota1 },
                {"Nota-2", nota2 },
                {"Media", media },
                {"Diciplinas", diciplinas }
            };
            ExibirDadosAluno(aluno);
            VerificaAprovacao(media);

        } while (Continuar());//adiciona u  metodo
        Console.WriteLine("Seu programa foi finalizado");
    }
    private string ObterDado(string dado)
    {
        Console.Write($"Digite o Seu {dado}");
        return Console.ReadLine();
    }
    private byte ObterIdade()
    {
        Console.Write("Digite sua Idade, desde que voce tenha menos de 255 ");
        return byte.Parse(Console.ReadLine());
    }
    private float ObterNota(string nota) 
    {
        Console.WriteLine($"Digite a {nota}");
        return float.Parse(Console.ReadLine());
    }
    private float CalcularMedia(float n1, float n2)
    {
        return (n1 + n2) /2;

    }
    private List<string> ObterDiciplinas()
    {
        Console.WriteLine("Digite Suas Diciplinas Separadas Por Virgula (EX: Matematica, Portugues ): ");
        string diciplinasInput = Console.ReadLine();
        string[] diciplinasArray = diciplinasInput.Split(',');
        return new List<string>(diciplinasArray);
    }

    private void ExibirDadosAluno(Dictionary<string, object> aluno)
    {
        Console.WriteLine("Dados do aluno");
        foreach(var i in aluno)
        {
            Console.Write($"{i.Key}");
            if(i.Value is List<string> diciplinas)
            {
                Console.WriteLine(string.Join(",", diciplinas));    
            }
            else
            {
                Console.WriteLine($"{i.Value}");
            }
        }
    }

    private void VerificaAprovacao(float media)
    {
        bool aprovado = media > 7.0;
        Console.WriteLine($"Aprovado {aprovado}");
    }
    private bool Continuar()
    {
        Console.WriteLine("Deseja Continuar ? (s/n)");
        string resposta = Console.ReadLine().ToLower();

        return resposta == "s";
    }
}
