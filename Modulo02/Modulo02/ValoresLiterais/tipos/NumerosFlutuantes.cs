using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.tipos
{
    public class NumerosFlutuantes
    {
        public void Executarfloat()
        {
            // 3 tipos de ponto flutuante 

            //decimal usado para monetario, dinheiro  M, m no final
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            decimal comissao = 456.878m;

            //float f ou F no final do valor, usado para maioria dos casos
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            float raio = 7.87987979879f;

            // double nao precisa de dado adicional é a variavel default para numeros com . mas é a exceção no uso, pois é muito grande
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            double pi = 3.14159265359;

            double salario = 1000.49;
            double aumento = 100.51;
            double novoSalario = 1101.00;

            Console.WriteLine($"{salario} + {aumento} = {salario + aumento}");
            Console.WriteLine($"{novoSalario}");
            Console.WriteLine((salario + aumento) == novoSalario);
        }
    }
}
