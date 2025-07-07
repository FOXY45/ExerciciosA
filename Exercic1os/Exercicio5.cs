using System;

namespace Exercic1os
{
    public static class Exercicio5
    {
        public static void Executar()
        {
            int x, y, z, s;
            Console.WriteLine("Exercício 5: Digite dois números inteiros.");
            x = int.Parse(Console.ReadLine()!);
            y = int.Parse(Console.ReadLine()!);

            if (x > y)
            // Coloca os numeros em ordem crescente
            {
                z = x;
                x = y;
                y = z;
            }

            s = 0;
            for (int i = x + 1; i < y; i++)
            {
                if (i % 2 != 0)
                // Soma os números pares entre x e y
                {
                    s = s + i;
                }
            }
            // Exibe o resultado
            Console.WriteLine($"A soma dos números ímpares entre {x} e {y} é: {s}");
            // da para colocar dados em string entre chaves  {.}, muito útil.
        }
    }
}