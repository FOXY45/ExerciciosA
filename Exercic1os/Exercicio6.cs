using System;
using System.Globalization;
//SOMA E MÉDIA DE NÚMEROS
namespace Exercic1os
{
    public static class Exercicio6
    {
        public static void Executar()
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n;
            Console.WriteLine("Exercício 6: \n");
            Console.Write("Quantos números você vai digitar? ");
            n = int.Parse(Console.ReadLine()!);

            double[] v = new double[n];

            for (int i = 0; i < n; i++)
            //le a posicao do vetor, e o i++ le de 1 em 1
            {
                Console.Write($"Digite o {i + 1}º número: ");
                //variaveis em {.} dentro de string são lidas como strings
                v[i] = double.Parse(Console.ReadLine()!, CI);
            }

            Console.WriteLine("\nValores mencionados:");

            Console.WriteLine(string.Join(" ", v));
            //string.Join junta os valores do vetor com o espaço entre eles
            //mais pratico que o for, e mais fácil de ler, pois não precisa de contadores
            Console.WriteLine();

            double sm = 0;
            for (int i = 0; i < n; i++)
            {
                sm = sm + v[i];
            }
            double m = sm / n;
            Console.WriteLine($"Soma: {sm.ToString("F2", CI)}");
            Console.WriteLine($"Média: {m.ToString("F2", CI)}");
        }
    }
}
