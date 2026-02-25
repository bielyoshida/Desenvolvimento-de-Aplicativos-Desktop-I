using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 1;
            Console.Write("Digite um número entre 1 e 10: ");

            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10)
            {
                Console.Write("Opção inválida, digite um número entre 1 e 10:");
            }

            for (i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n * i}");
            }
        }
    }
}
