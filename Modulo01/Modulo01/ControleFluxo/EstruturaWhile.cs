using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.ControleFluxo
{
    public class EstruturaWhile
    {
        public void ExecutarWhile()
        {
            int pontuacao = 0;
            bool jogadorGanhou = false;

            Console.WriteLine("Bem-vindo ao jogo!");

            while (!jogadorGanhou)
            {
                Console.WriteLine($"Sua pontuação atual é {pontuacao}");
                Console.Write("Você ganhou? (Sim/Não): ");
                string resposta = Console.ReadLine();

                // Verifica se a resposta do jogador é "Sim" (case-insensitive)
                //A linha seguinte verifica se a resposta do jogador é "Sim"
                //(independentemente de ser maiúscula ou minúscula).
                //Isso é feito usando o método Equals com StringComparison.OrdinalIgnoreCase.
                //Se a resposta for "Sim", o programa faz o seguinte
                if (resposta.Equals("Sim", StringComparison.OrdinalIgnoreCase))
                {
                    jogadorGanhou = true;
                    Console.WriteLine("Parabéns! Você ganhou o jogo.");
                }
                else
                {
                    Console.WriteLine("Continue jogando...");
                    pontuacao++;
                }
            }
        }
    }
}
