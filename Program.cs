using System;

namespace Exercicios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Qual exercicio deseja Debugar: (1 a 5) ");
            int exercicio = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            switch (exercicio)
            {
                case 1: Exercicio1.Executar(); break;
                case 2: Exercicio2.Executar(); break;
                case 3: Exercicio3.Executar(); break;
                case 4: Exercicio4.Executar(); break;
                case 5: Exercicio5.Executar(); break;
                default:
                    Console.WriteLine("Exercício não encontrado.");
                    break;
            }
        }
    }
}

