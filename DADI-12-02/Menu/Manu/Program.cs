using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opção = 0;

            while (opção != 3)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Sair");
                Console.Write("\nDigite a opção desejada: ");

                if (!int.TryParse(Console.ReadLine(), out opção))
                {
                    Console.WriteLine("Opção inválida");
                    continue;
                }

                switch (opção)
                {
                    case 1:
                        Console.WriteLine("\nVocê escolheu cadastrar");
                        break;

                    case 2:
                        Console.WriteLine("\nVocê escolheu listar");
                        break;

                    case 3:
                        Console.WriteLine("\nSaindo...");
                        break;
                    default:
                        Console.WriteLine("\nNão existe");
                        break;
                }
            }
        }
    }
}
