using System;
using Exercic1os;

namespace Exercicios
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            int exercicio;
             while (true)
            {
                Console.Write("Digite o número do exercício (1 a 10): ");
                if (int.TryParse(Console.ReadLine(), out exercicio) && exercicio >= 1 && exercicio <= 10)
                {
                    Console.WriteLine("");
                    break; // sai do while se o número for válido
                }

                Console.WriteLine("Entrada inválida. Por favor, digite um número de 1 a 10.\n");
            }

            switch (exercicio)
            {
                case 1: Exercicio1.Executar(); break;
                case 2: Exercicio2.Executar(); break;
                case 3: Exercicio3.Executar(); break;
                case 4: Exercicio4.Executar(); break;
                case 5: Exercicio5.Executar(); break;
                case 6: Exercicio6.Executar(); break;
                case 7: Exercicio7.Executar(); break;
                case 8: Exercicio8.Executar(); break;
                case 9: Exercicio9.Executar(); break;
                case 10: Exercicio10.Executar(); break;
                
                default:
                    Console.WriteLine("Exercício ainda não implementado.");
                    break;

            }
        }
    }
}
