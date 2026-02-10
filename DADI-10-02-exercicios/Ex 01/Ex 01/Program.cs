using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            string idade = Console.ReadLine();

            Console.Write("Seu nome é "+nome+" e sua idade é "+idade+" anos");
        }
    }
}
