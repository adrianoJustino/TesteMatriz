using System;

namespace TesteMatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            /*O programa receberá uma matriz N por M, você escolherá X onde X é um valor qualquer da matriz, em seguida o programa te dirá quais valores 
            estão acima, abaixo, esquerda e direita do valor X*/

            int[,] matriz;
            int n, m, x;

            Console.WriteLine("Digite o a quantidade de linhas: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o a quantidade de colunas: ");
            m = int.Parse(Console.ReadLine());

            matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Digite o valor da posição " + i + j +" da matriz");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
