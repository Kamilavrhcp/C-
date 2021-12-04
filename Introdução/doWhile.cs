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
            int contador = 0;

            do
            {
              Console.WriteLine("Rodando o While!");
              contador ++;
            } while (contador < 5);

            Console.ReadLine();
        }
    }
}