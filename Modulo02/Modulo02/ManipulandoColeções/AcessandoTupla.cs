using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.Coleções
{
    internal class AcessandoTupla
    {
        public void Executar()
        {
            //tupla
            var pessoa = (Nome: "Andre", Idade: 26);
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        }


    }
}
