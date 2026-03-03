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
            List<string> alunos = new List<string>();
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
                        Console.WriteLine("Digite o nome do aluno:"); 
                        string nome = Console.ReadLine();
                        if (string.IsNullOrEmpty(nome))
                        {
                            Console.WriteLine("Nome inválido.");
                        } 
                        else 
                        {
                           alunos.Add(nome.Trim()); 
                           Console.WriteLine("Aluno foi adicionado!");
                        }
                        break;

                    case 2:
                        if(alunos.Count == 0)
                        {
                            Console.WriteLine("Nenhum aluno cadastrado.");
                        }
                        else
                        {
                            Console.WriteLine("Lista de alunos:");

                            for (int j = 0; j < alunos.Count; j++)
                            {
                                Console.WriteLine($"{j + 1}. {alunos[j]}");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Nome para remover:"); 
                        string remover = Console.ReadLine();
                        bool removido = alunos.Remove(remover);
                        Console.WriteLine(removido ? "Removido com sucesso." : "Aluno não encontrado");
                        break;

                    case 4:
                        Console.WriteLine($"O total de alunos cadastrados é {alunos.Count}");
                    break;

                    default:
                        Console.WriteLine("\nOpção não disponível");
                        break;
                }

            }
        }
    }
}
