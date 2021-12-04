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

            // for(int index = 0; index < palavras.Length; index++) crescente
            for(int index = palavras[-1]; index >= 0; index--)
            {
              Console.WriteLine(palavras[index]);

            }

            Console.ReadLine();
        }
    }
}