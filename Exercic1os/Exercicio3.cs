using System;
using System.Globalization;
//EXERCICIO SOBRE <3
namespace Exercic1os
{
    public static class Exercicio3
    {
        public static void Executar()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int n, m, y, mr;

            Console.WriteLine("Exercício 3: MENOR NUMERO");
            Console.Write("Digite o primeiro números: ");
            n = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o segundo números: ");
            m = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o terceiro números: ");
            y = int.Parse(Console.ReadLine()!);
            //Console.WriteLine(n % 2 == 0 ? "Par" : "Ímpar"); 
            // consegue executar um pequeno if sem ter que explicar muito
            if (n < m && n < y)
            {
                mr = n;
            }
            else if (m < y)
            {
                mr = m;
            }
            else
            {
                mr = y;
            }
            Console.WriteLine("MENOE ENTRE OS 3 = " + mr);
        }
    }
}
