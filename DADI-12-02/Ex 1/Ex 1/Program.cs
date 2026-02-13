using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n != 1 && n != 2 && n != 3)
            {
                List<string> list = new List<string>();

                list.Add("Geladeira");
                list.Add("Chaleira");
                list.Add("Micro-ondas");

                Console.WriteLine("Temos disponíveis:\n1 - Geladeiras \n2 - Chaleiras \n3 - Micro-ondas");
                Console.Write("Digite o nome do eletrodoméstico que você quer comprar: ");

                if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 3)
                {
                    Console.WriteLine("\nOpção inválida\n");
                    continue;
                }

                switch (n)
                {
                    case 0:
                        Console.WriteLine("Você comprou uma geladeira");
                        break;
                    case 1:
                        Console.WriteLine("Você comprou uma chaleira");
                        break;
                    case 2:
                        Console.WriteLine("Você comprou um micro-ondas");
                        break;
                }
            }
        }
    }
}
