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
            double x = 10.35785;

            // Console.WriteLine(x.ToString("F3")); // quantidade de casas décimais
            // string[] vet = Console.ReadLine().Split(' ');
            // string leg1 = vet[0];
            // string leg2 = vet[1];
            // string leg3 = vet[2];
            // Console.WriteLine(leg1);
            // Console.WriteLine(leg2);
            // Console.WriteLine(leg3);
            Console.WriteLine("Entre com o seu nome completo");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem a sua casa?");
            int houseroom = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double productPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura:");
            string[] date = Console.ReadLine().Split(' ');
            string name = date[0];
            int age = int.Parse(date[1]);
            double heigth = double.Parse(date[2]);
            Console.WriteLine(fullName);
            Console.WriteLine(houseroom);
            Console.WriteLine(productPrice);
            Console.WriteLine(name + " " + age + " " + heigth);

        }
    }
}