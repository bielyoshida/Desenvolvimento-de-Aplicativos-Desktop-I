using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    internal class Program
    {
        class Aluno
        {
            public string nome { get; set; }
            public float[] notas { get; set; } = new float[3];
            public string situação { get; set; }
            public double media = 0;

        }
        static void Main(string[] args)
        {
            int max = 0;
            int aprovados = 0;
            string nomeMaior = "";
            double maiorMedia = 0;
            List<Aluno> alunos = new List<Aluno>();

            Console.Write("Quantos alunos serão registrados: ");
            int i = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < i; j++)
            {
                Aluno a = new Aluno();
                Console.Write($"Nome do aluno {j + 1}: ");
                a.nome = Console.ReadLine();
                for (int n = 0; n < 3; n++)
                {
                    Console.Write($"nota {n + 1}: ");
                    a.notas[n] = Convert.ToSingle(Console.ReadLine());
                }
                
                a.media = (a.notas[0] + a.notas[1] + a.notas[2]) / 3;

                if (a.media > maiorMedia)
                {
                    maiorMedia = a.media;
                    nomeMaior = a.nome;
                }

                if(a.media > 6)
                {
                    a.situação = "Aprovado";
                    aprovados++;
                }
                else
                {
                    a.situação = "Reprovado";
                }
                alunos.Add(a);
            }
                
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"\nNome do aluno: {alunos[j].nome}");
                Console.WriteLine($"A média dele(a) é: {alunos[j].media}");
                Console.WriteLine($"A situação dele(a) é: {alunos[j].situação}");
            }
            Console.WriteLine($"\nA maior média foi do(a) aluno(a) {nomeMaior}");
            Console.WriteLine($"A média dele(a) foi {maiorMedia}");
            Console.WriteLine($"A quantidade de aprovados é {aprovados}");
            Console.ReadKey();
        }
    }
}
