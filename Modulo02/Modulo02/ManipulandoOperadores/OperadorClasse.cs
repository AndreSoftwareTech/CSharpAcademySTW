using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.ManipulandoOperadores
{
    internal class OperadorClasse
    {
        public void Executar()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Alice";
            pessoa.Idade = 30;
            Console.WriteLine(pessoa.Nome); // Acessando o membro da classe.

        }
    }
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }



}
