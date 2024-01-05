using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.ManipulandoString
{
    public class ManipulandoString
    {
        public void Exemplo01() 
        {
            //imutabilidade
            string nome = "Andre";
            nome = nome + " Vitor"; // Cria uma nova string em vez de modificar a original
            Console.WriteLine(nome);

        }
        public void Exemplo02() 
        {
            //string literal
            string mensagem = "Olá, mundo!";

        }
        public void Exemplo03() 
        {
            //string Interpoladas
            string nome = "Andre";
            string saudacao = $"Olá, {nome}!";
            Console.WriteLine(saudacao);

        }
        public void Exemplo04() 
        {
            //Operacoes Frequentes string texto = "Esta é uma string de exemplo.";
            string texto = "Esta é uma string de exemplo.";
            int comprimento = texto.Length;

            string subtexto = texto.Substring(5, 10); // Pega uma substring a partir do índice 5 com comprimento 10
            string maiusculas = texto.ToUpper();
            string minusculas = texto.ToLower();
            Console.WriteLine(comprimento);
            Console.WriteLine(subtexto);
            Console.WriteLine(maiusculas);
            Console.WriteLine(minusculas);

        }
        public void Exemplo05() 
        {
            //formatando uma string 
            int idade = 30;
            string mensagem = string.Format("Eu tenho {0} anos.", idade);

            Console.WriteLine(mensagem);


        }

        public void Exemplo06() 
        {
            string texto = "   Espaços em branco ao redor   ";
            string trim = texto.Trim(); // Remove espaços em branco ao redor
            Console.WriteLine(trim);


        }

        public void Exemplo07() 
        {
            //dividindo uma string
            string lista = "maçã/banana/uva/laranja/abacate";
            string[] frutas = lista.Split('/');
            Console.WriteLine(frutas);

            //For iterando um vetor
            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine(frutas[i]);
            }
        }
        public void Exemplo08() 
        {   //substring
            string texto = "Exemplo de substring em C#";
            string sub = texto.Substring(8, 9); // Pega "substring"
            Console.WriteLine(sub);
        }

        public void Exemplo09() 
        {
            string texto = "Exemplo de CaSe InSeNsItIvE";
            string maiusculas = texto.ToUpper();
            string minusculas = texto.ToLower();
            Console.WriteLine(maiusculas);
            Console.WriteLine(minusculas);


        }
        public void Exemplo10() 
        {
            //Trabalhando com "String.Format":
            int temperatura = 25;
            string mensagem = string.Format("A temperatura é {0}°C.", temperatura);
            Console.WriteLine(mensagem);
        }
 
    }
}
