using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            string[] alunos = new string[0];

            while (i != 5)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Adicionar aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3- Remover aluno pelo número");
                Console.WriteLine("4 - Mostrar total");
                Console.WriteLine("5 - Sair");

                if(!int.TryParse(Console.ReadLine(), out i))
                { 
                    Console.WriteLine("Opção inválida");                
                }

                switch (i)
                {
                    case 1:
                    


                    default:
                        Console.WriteLine("\nOpção não disponível");
                }

            }
        }
    }
}
