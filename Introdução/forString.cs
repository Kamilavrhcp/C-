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
            string[] palavras = {"Subsonica", "Pearl Jam", "SoundGarden", "Red Hot Chili Peppers"};
            Console.log("Melhores bandas do mundo:");

            for(int contador = 0; contador < palavras.Length; contador++)
            {
              Console.WriteLine(palavras);

            }

            Console.ReadLine();
        }
    }
}