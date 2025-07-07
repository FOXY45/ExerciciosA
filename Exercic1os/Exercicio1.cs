using System;
using System.Globalization;
//EXERCICIO SOBRE MATRIZES
namespace Exercic1os
{
    public static class Exercicio1
    {
        public static void Executar()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int M, N;

            Console.Write("Quantas linhas teram sua Matriz? ");
            M = int.Parse(Console.ReadLine()!, CI);
            // ^^^ equivalente a 'leia(m)' do visualG ^^^

            Console.Write("Quantas colunas teram sua Matriz? ");
            N = int.Parse(Console.ReadLine()!, CI);

            int[,] v = new int[M, N];

            for (int i = 0; i < M; i++)
            //mesma coisa que 'para i de 0 ate M faca'
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("\n ELEMENTO [" + i + "|" + j + "]: ");
                    v[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA:");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(v[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
