using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite a sua idade: ");
                int idade = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Idade informada: " + idade);
            }
            catch 
            {
                Console.WriteLine("Você não escreveu um valor válido");
            }
        }
    }
}
