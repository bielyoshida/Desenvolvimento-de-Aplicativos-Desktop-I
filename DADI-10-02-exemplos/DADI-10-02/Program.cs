using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADI_10_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exemplo de uma repetição for
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */
            string t = "";
            while (t != "sair")
            {
                Console.WriteLine("digite algo (ou 'sair'): ");
                t = Console.ReadLine();
                Console.WriteLine("Você digitou: " + t);
            }
            Console.WriteLine("Programa encerrado");
            Console.ReadLine();
        }
    }
    }
