using System;
using System.Globalization;
//PROGRAMA SEM ORENTAÇÃO A OBJETOS
namespace Exercic1os
{
    public static class Exercicio10
    {
        public static void Executar()
        {
            
            var CI = CultureInfo.InvariantCulture;
            double media = 0.0;
        
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Declare as medidas do triangulo X:");
            xA = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Declare as medidas do triangulo Y:");
            yA = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            
            //CALCULO PARA DETERMINAR A AREA DOS TRIANGULOS
            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            double h = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(h * (h - yA) * (h - yB) * (h - yC));

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CI));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CI));
        
            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            media = areaX / areaY;
            Console.WriteLine("A área de X e Y coresponde =", media);
            /*
            Triangulo x = LerTriangulo("X", ci);
            Triangulo y = LerTriangulo("Y", ci);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Área de X = {areaX:F4}");
            Console.WriteLine($"Área de Y = {areaY:F4}");

            string maior = areaX > areaY ? "X" : "Y";
            Console.WriteLine($"Maior área: {maior}");

            Console.WriteLine($"A razão entre as áreas = {areaX / areaY:F4}");
        }

        private static Triangulo LerTriangulo(string nome, CultureInfo ci)
        {
            Console.WriteLine($"Declare as medidas do triângulo {nome}:");
            double a = double.Parse(Console.ReadLine()!, ci);
            double b = double.Parse(Console.ReadLine()!, ci);
            double c = double.Parse(Console.ReadLine()!, ci);
            return new Triangulo(a, b, c);
        }

        private class Triangulo
        {
            private readonly double a, b, c;

            public Triangulo(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double Area()
            {
                double p = (a + b + c) / 2.0;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            */
        }

    }

}