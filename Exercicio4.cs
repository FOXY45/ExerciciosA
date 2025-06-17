using System;
using System.Globalization;
//CRESCENTE OU DECRESCENTE??????
namespace Exercicios
{
    public static class Exercicio4
    {
        public static void Executar()
        {
            int N, x, y;
            Console.WriteLine("Exercício 4: Crescente ou Decrescente");
            Console.Write("Quantas X deseja rodar este code: ");
            N = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite dois numeros: ");
                x = int.Parse(Console.ReadLine()!);
                y = int.Parse(Console.ReadLine()!);

                if (x < y)
                {
                    Console.WriteLine("Ordem Crescente!");
                }
                else if (x > y)
                {
                    Console.WriteLine("Ordem Descrescente!");
                }
                else
                //Tinha esquecido da possibilidade deles serem iguais
                //  na hora de escrever o code, o GPT colcou para mim.
                {
                    Console.WriteLine("Números iguais!");
                }
            }
        }
    }
}
