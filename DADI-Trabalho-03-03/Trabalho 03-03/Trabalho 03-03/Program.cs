using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> aluno = new List<Aluno>();
            int intTemporario = 0;
            float floatTemporario = 0;
            float imc = 0;
            int i = 0;
            int j = 0;

            while (i != 3)
            {
                Console.WriteLine("\nMenu Academia");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Sair");
                Console.Write("Digite a opção desejada: ");
                
                if(!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.WriteLine("Opção inválida");
                    continue;
                }

                switch (i)
                {
                    case 1:
                        Aluno a = new Aluno();
                        Console.Write("\nDigite o nome do aluno: "); 
                        a.nome = Console.ReadLine();

                        Console.Write("Digite a idade do aluno: ");
                        while (!int.TryParse(Console.ReadLine(), out intTemporario))
                        {
                            Console.Write("Opção inválida, digite a idade do aluno: ");
                        }
                        a.idade = intTemporario;

                        Console.Write("Digite o peso do aluno: ");
                        while (!float.TryParse(Console.ReadLine(), out floatTemporario))
                        {
                            Console.Write("Opção inválida, digite o peso do aluno: ");
                        }
                        a.peso = floatTemporario;
                        
                        Console.Write("Digite a altura do aluno: ");
                        while (!float.TryParse(Console.ReadLine(), out floatTemporario))
                        {
                            Console.Write("Opção inválida, digite a altura do aluno: ");
                        }
                        a.altura = floatTemporario;

                        aluno.Add(a);

                        Console.WriteLine("Aluno Cadastrado com sucesso");
                        break;

                    case 2:
                        foreach (Aluno temporario in aluno)
                        {
                            imc = IMC.calcular(temporario.peso, temporario.altura);
                            Console.WriteLine($"\nNome: {temporario.nome}");
                            Console.WriteLine($"IMC: {imc}");
                            Console.WriteLine($"Classsificação: {IMC.classificar(imc)}");
                        }
                        break;

                    default:
                        Console.WriteLine("Número inválido!");
                        break;
                }
            }
        }
    }
}
