using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe sua média: ");
            double media = Convert.ToDouble(Console.ReadLine());

            if (media >= 6)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reporvado");
            }


        }
    }
}
