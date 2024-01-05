using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01.estruturado;

public class VariavelMatriz
{
    public void ExcutarMatriz()
    {
        int[,] matriz = new int[3, 3];

        // Preenchendo a matriz com valores
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[0, 2] = 3;
        matriz[1, 0] = 4;
        matriz[1, 1] = 5;
        matriz[1, 2] = 6;
        matriz[2, 0] = 7;
        matriz[2, 1] = 8;
        matriz[2, 2] = 9;

        // Acessando e exibindo os valores da matriz
        Console.WriteLine("Matriz 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine(); // Nova linha para cada linha da matriz
        }
    }
}
