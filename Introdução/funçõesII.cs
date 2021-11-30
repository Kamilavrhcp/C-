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
            ExibirMsg();
            GerarPreco(-4, "Morango");
            Console.WriteLine(Somar(2, 4, 5));
            Console.ReadLine();
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Sistema 1");
            Console.WriteLine("Sistema 2");
            Console.WriteLine("Sistema 3");
        }

        static void GerarPreco(int preco, string nome)
        {
            int precoAbs = Math.Abs(preco); // para receber somente números positivos
            int valorFinal = 2 * precoAbs;
            Console.WriteLine("Nome do produto: " + nome + ": " + valorFinal);
        }
        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
    }
}