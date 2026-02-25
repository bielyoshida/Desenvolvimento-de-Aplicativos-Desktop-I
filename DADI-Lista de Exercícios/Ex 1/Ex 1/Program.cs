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
            int idade = 0;
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            while (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.Write("Opção inválida, digite sua idade: ");
            }

            Console.WriteLine("Seu nome é " + nome);
            Console.Write("De acordo com a sua idade você é ");

            if (idade < 18)
            {
                Console.Write("Menor de idade");
            }
            else if (idade >= 18 && idade <= 59)
            {
                Console.Write("Adulto");
            }
            else
            {
                Console.Write("Idoso");
            }


        }
    }
}
