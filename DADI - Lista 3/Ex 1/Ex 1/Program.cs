using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        public class Funcionario
        {
            public string nome;
            private double salario;

            public double ObterSalario()
            {
                return salario;
            }

            public void DefinirSalario()
            {
                Console.Write("Digite o seu salário: ");
                while (!double.TryParse(Console.ReadLine(), out salario) || salario < 0)
                {
                    Console.WriteLine("Salário inválido, digite o seu salário: ");
                }
            }
            public double AumentarSalario(double porc)
            {
                salario = salario + (salario * porc / 100);
                return salario;
            }
        }
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>();
            int i = 0;
            int j;
            double porc = 0;

            while (i != 3)
            {
                Console.WriteLine("\nMenu Funcionários");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Aplicar aumento");
                Console.WriteLine("3 - Sair");
                Console.Write("Digite a opção desejada: ");

                if (!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.WriteLine("Opção inválida");
                }

                switch (i)
                {
                    case 1:
                        Funcionario f = new Funcionario();
                        Console.Write("\nDigite o nome do funcionário: ");
                        f.nome = Console.ReadLine();
                        
                        f.DefinirSalario();

                        funcionario.Add(f);
                        Console.WriteLine("Funcionário cadastrado com sucesso");
                        break;

                    case 2:
                        Console.Write("\nDigite a porcentagem do aumento do salário: ");
                        if(!double.TryParse(Console.ReadLine(), out porc))
                        {
                            Console.Write("Dados inválidos, Digite uma porcentagem: ");
                            return;
                        }
                        for (j = 0; j < funcionario.Count;j++)
                        {
                            funcionario[j].AumentarSalario(porc);
                            Console.WriteLine($"Nome: {funcionario[j].nome}");
                            Console.WriteLine($"Salário aumentado: {funcionario[j].ObterSalario():F2}");
                        }
                        break;

                    default:
                        Console.WriteLine("Número inválido");
                        break;
                }
            }
        }
    }
}
