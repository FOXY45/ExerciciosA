using System;
using System.Globalization;
//ESTRUTURA REPETITIVA 'FOR'
namespace Exercic1os
{
    public static class Exercicio9
    {
        public static void Executar()
        {
            int soma = 0;

            Console.Write("Quantos numeros inteiros deseja digitar? ");
            int N = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= N; i++)
            // Declara em que numero deve iniciar (int i = 1...)
            // Declara o valor maximo que i pode atingir (i <= N...)
            // Declara o encremento de 1 em 1, até atingir N (...i++)
            {
                Console.Write($"Valor #{i}: ");
                int v = int.Parse(Console.ReadLine()!);
                soma = soma + v;
            }

            Console.WriteLine($"A soma dos {N} numeros digitados foi de:");
            Console.WriteLine($"Total = {soma}");
        }
    }
}