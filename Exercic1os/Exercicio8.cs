using System;
using System.Globalization;
//OPERADORES LOGICOS
namespace Exercic1os
{
    public static class Exercicio8
    {
        public static void Executar()
        {
            bool c1 = 2 > 10 || 5 != 4; // true
            bool c2 = !(2 < 10) && 5 != 4; // false

            Console.WriteLine($"{c1} e {c2}");
        }
    }
}