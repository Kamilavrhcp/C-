using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual é a largura do terreno?");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual é a altura do terreno?");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;

            Console.WriteLine("A área do terreno é: " + area.ToString("F2", CultureInfo.InvariantCulture) + "m²");

            double valorMetroQuadrado = 200.00;
            double preco = area * valorMetroQuadrado;
            Console.WriteLine("O preço do terreno é: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}