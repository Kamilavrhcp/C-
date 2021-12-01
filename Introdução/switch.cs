using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        enum Cor { Vermelho, Preto, Verde}

        static void Main(string[] args)
        {
            Cor CorFavorita = Cor.Vermelho;
            Console.WriteLine(CorFavorita);

            Cor CorUsandoCast = Cor.Preto;
            Console.WriteLine((int)CorUsandoCast);
            Console.WriteLine((Cor)1);

            string cor = "Branca";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!");
                    break;
                case "Preto":
                    Console.WriteLine("Sua cor favorita é preta!");
                    break;
                case "Verde":
                    Console.WriteLine("Sua cor favorita é Verde!");
                    break;
                default:
                    Console.WriteLine("Não sei a sua cor favorita!");
                    break;
            }
            Console.ReadLine();
        }

    }
}