using System;
using System.Globalization;
//DIAGONAL E NEGATIVOS
namespace Exercicios
{
    public static class Exercicio7
    {
        public static void Executar()
        {
            int N, C;
            C = 0;
            Console.WriteLine("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine()!);

            int[,] V = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"[ {i} | {j} ]: ");
                    V[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.Write("Diagonal Princial:\n");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{V[i, i]} ");
            }

            Console.WriteLine("");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {


                    if (V[i, j] < 0)
                    {
                        C++;
                    }
                }
            }

            Console.Write($"Quantidades de negativos = {C}");

        }
    }
}