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
            string[] produtos = new string[5] { "Sea of thieves", "FIFA", "Minecraft", "Half-life", "Portal"};

            produtos[1] = "Fifa 2021";

            Console.WriteLine(produtos[1]);

            int[] valores = { 40, 50, 60, 70 }; // array mais simples
            Console.WriteLine(valores[2]);

            Console.ReadLine();
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Sistema 1");
            Console.WriteLine("Sistema 2");
            Console.WriteLine("Sistema 3");
        }

    }
}