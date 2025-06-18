using System;

namespace Exercicios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int exercicio;

            while (true)
            {
                Console.Write("Digite o número do exercício (1 a 6): ");

                // Tenta converter a entrada em número e valida se está entre 1 e 6
                if (int.TryParse(Console.ReadLine(), out exercicio) && exercicio >= 1 && exercicio <= 6)
                {
                    Console.WriteLine("");

                    switch (exercicio)
                    {
                        case 1: Exercicio1.Executar(); break;
                        case 2: Exercicio2.Executar(); break;
                        case 3: Exercicio3.Executar(); break;
                        case 4: Exercicio4.Executar(); break;
                        case 5: Exercicio5.Executar(); break;
                        case 6: Exercicio6.Executar(); break;
                    }

                    break; // encerra o loop após execução
                }
                else
                {
                    Console.WriteLine("Número inválido.\n");
                }
            }
        }
    }
}