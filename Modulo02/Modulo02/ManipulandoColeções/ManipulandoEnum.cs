using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.ManipulandoColecoes
{
    enum DiasDaSemana
    {
        Domingo,
        Segunda ,
        Terça,
        Quarta ,
        Quinta,
        Sexta,
        Sábado
    }

    internal class ManipulandoEnum
    {

        public  void Executar()
        {
            DiasDaSemana hoje = DiasDaSemana.Segunda;


            if (hoje == DiasDaSemana.Sábado || hoje == DiasDaSemana.Domingo)
            {
                Console.WriteLine("É fim de semana!");
            }
            else
            {
                Console.WriteLine("É dia útil.");
            }

        }
    }


}
