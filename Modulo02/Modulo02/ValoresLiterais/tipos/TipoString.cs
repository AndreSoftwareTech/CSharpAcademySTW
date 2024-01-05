using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.tipos
{
    public class TipoString
    {
        public void ExecutarString() 
        {
            // tipo primitivo char
            char letra = 'A';
            char digito = '7';
            char simbolo = '$';
            Console.WriteLine("Minimo valor e maximo valor Char");
            Console.WriteLine(char.MinValue);
            Console.WriteLine(char.MaxValue);

            //tipo primitivo string
            string nome = "Andre";
            string frase = "Olá, mundo!";
            string texto = "Isso é uma string.";

            int comprimento = texto.Length; // Retorna o número de caracteres na string.
            Console.WriteLine("Minimo valor e maximo valor String");
            Console.WriteLine(comprimento);




        }



    }
}
