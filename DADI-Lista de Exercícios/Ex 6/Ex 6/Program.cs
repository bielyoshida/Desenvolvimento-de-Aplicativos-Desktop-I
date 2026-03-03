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
            public double[] notas { get; set; } = new double[3];
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
                }
                else
                {
                    a.situação = "Reprovado";
                }

            }
                

            Console.WriteLine($"Nome do aluno: {a.nome}");
            Console.WriteLine($"A maior nota é: {max}");
            Console.WriteLine($"A menor nota é: {min}");

        }
    }
}
