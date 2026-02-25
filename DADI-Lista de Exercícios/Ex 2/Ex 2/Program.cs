using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma de a + b = " + Somar(a, b)); 
        }

        static int Somar(int a, int b)
        {
            return a + b;
        }
    }
}
