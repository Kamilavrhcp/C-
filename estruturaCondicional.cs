using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 11)
            {
                Console.WriteLine("Você é uma criança!");
            } else if (age >= 12 && age <= 18)
            {
                Console.WriteLine("Você é um adolescente!");
            } else if (age >= 19 && age <= 60)
            {
                Console.WriteLine("Você é um adulto!");
            }
            else
            {
                Console.WriteLine("Você é um idoso");
            }

            Console.ReadLine();
        }
    }
}