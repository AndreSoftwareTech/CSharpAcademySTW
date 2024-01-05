using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.ManipulandoData
{
    public class ManipulandoDatas
    {
        public void Exemplo01()
        {
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine("Data e hora atuais: " + dataAtual);

            //metodos DateTime
            DateTime data = new DateTime(2023, 10, 29);

            Console.WriteLine("Ano: " + data.Year);
            Console.WriteLine("Mês: " + data.Month);
            Console.WriteLine("Dia: " + data.Day);
        }
        public void Exemplo02()
        {
            DateTime data1 = DateTime.Now;
            string dataFormatada = data1.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine("Data formatada: " + dataFormatada);
        }

        public void Exemplo03()
        {
            //Date Time Array
            DateTime data = DateTime.Now;
            //adiciona dia a data atual, ou seja, segue para o proximo dia do calendario
            DateTime dataAmanha = data.AddDays(1);
            //Adiciona hora ao valor atual e contabiliza nas 24hs
            DateTime daquiA3Horas = data.AddHours(3);
            Console.WriteLine("Amanhã: " + dataAmanha);
            Console.WriteLine("Daqui a 3 horas: " + daquiA3Horas);
        }

        public void Exemplo04()
        {
            //Date Time Parse
            string dataString = "10/09/2023 15:30:00";

            DateTime data3 = DateTime.Parse(dataString);
            Console.WriteLine("Data parseada: " + data3);

        }

   
        public void Exemplo05()
        {
            string dataInvalida = "abc";

            if (DateTime.TryParse(dataInvalida, out DateTime resultado))
            {
                Console.WriteLine("Data válida: " + resultado);
            }
            else
            {
                Console.WriteLine("Data inválida");
            }

        }
        public void Exemplo06()
        {

            //"DateTime.AddMilliseconds" e "DateTime.AddYears":
            DateTime data4 = DateTime.Now;
            DateTime daquiA500Milissegundos = data4.AddMilliseconds(500);
            DateTime daquiA5Anos = data4.AddYears(5);
            Console.WriteLine("Daqui a 500 milissegundos: " + daquiA500Milissegundos);
            Console.WriteLine("Daqui a 5 anos: " + daquiA5Anos);
        }

        public void Exemplo07()
        {
            //"DateTime.Compare":
            DateTime data5 = DateTime.Now;
            DateTime data6 = new DateTime(2023, 09, 11);
            int resultado2 = DateTime.Compare(data5, data6);
            Console.WriteLine("Resultado da comparação: " + resultado2);
        }
        public void Exemplo08()
        {
            //Trabalhando com "DateTime.DaysInMonth":
            int ano = 2023;
            int mes = 9;
            int diasNoMes = DateTime.DaysInMonth(ano, mes);
            Console.WriteLine("Dias em setembro de 2023: " + diasNoMes);

        }
        public void Exemplo9()
        {
            string dataString1 = "2023-09-10";
            DateTime data8;
            if (DateTime.TryParseExact(dataString1, "yyyy-MM-dd", null, DateTimeStyles.None, out data8))
            {
                Console.WriteLine("Data parseada: " + data8);
            }

        }
        public void Exemplo10()
        {
            //Exemplo - 11
            DateTime data = DateTime.ParseExact("09/10/2023", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Data parseada: " + data);

        }

        public void Exemplo11()
        {

            //Utilizando "DateTime" como inicializador de um for-loop:
            for (DateTime data10 = DateTime.Now; data10 < DateTime.Now.AddDays(5); data10 = data10.AddDays(1))
            {
                Console.WriteLine("Data: " + data10.ToString("dd/MM/yyyy"));
            }

        }
    }
}
