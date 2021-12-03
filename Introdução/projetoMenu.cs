using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        enum Alternativa { Sim = 1, Não }

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar\n");
            int index = int.Parse(Console.ReadLine());
            Opcao OpcaoSelectionada = (Opcao)index;

            switch (OpcaoSelectionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Parabéns! Você criou algo novo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você quer deletar?");
                    Console.WriteLine("Digite:\n 1-Sim \n 2-Não\n");
                    int alternativaIndex = int.Parse(Console.ReadLine());
                    Alternativa AlternativaSelecionada = (Alternativa)alternativaIndex;
                    Opcao_deletar((Alternativa)AlternativaSelecionada);
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Arquivo editado com sucesso!");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Aguarde...\n Filme: The Matrix - Ano de lançamento: 31 de março de 1999, \n Filme: The Matrix Reloaded - Ano de lançamento: 15 de maio de 2003, \n Filme: The Matrix Revolutions - Ano de lançamento: 05 de novembro de 2003, \n Filme: The Matrix Resurrections - Ano de lançamento: 22 de dezembro de 2021");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Arquivo atualizado com sucesso!");
                    break;
                default:
                    Console.WriteLine("Digite a opção correta.");
                    break;
            }
            Console.ReadLine();

        }
        static void Opcao_deletar(Alternativa Alternativa)
        {
            switch (Alternativa)
            {
                case Alternativa.Sim:
                    Console.WriteLine("Deletado com sucesso");
                    break;
                case Alternativa.Não:
                    Console.WriteLine("Digite 3 para sair do menu");
                    break;
                default:
                    Console.WriteLine("Não existe essa alternativa");
                    break;
            }

            Console.ReadLine();
        }
    }
}