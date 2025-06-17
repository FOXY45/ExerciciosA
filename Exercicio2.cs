using System;
using System.Globalization;
//EXERCICIO SOBRE AREA DE RETANGULO
namespace Exercicios
{
    public static class Exercicio2
    {
        public static void Executar()
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double baze, altura, area, perimetro, diagonal;

            Console.WriteLine("Exercício 2: AREA RETANGULAR");
            Console.Write("Digite a base do retangulo que deseja calcular: ");
            baze = double.Parse(Console.ReadLine()!, CI);
            Console.Write("Digite a altura do retangulo : ");
            altura = double.Parse(Console.ReadLine()!, CI);

            area = baze * altura;
            perimetro = 2 * (baze + altura);
            diagonal = Math.Sqrt(Math.Pow(baze, 2.0) + altura * altura);
            //Estude o que esses Math, o .Pow é para potenciação

            Console.WriteLine("Area = " + area.ToString("F4", CI));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CI));
            Console.WriteLine("Diagonal = "  + diagonal.ToString("F4", CI));
        }
    }
}
