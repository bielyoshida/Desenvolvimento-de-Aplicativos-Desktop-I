using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media = 0;
            float max = 0;
            float min = 10;

            Console.Write("Quantas notas você vai digitar: ");
            int i = Convert.ToInt32(Console.ReadLine());

            float[] notas = new float[i];

            for (int j = 0; j < i; j++)
            {
                Console.Write($"nota {j + 1}: ");
                notas[j] = Convert.ToSingle(Console.ReadLine());
            }

            for (int j = 0; j < i; j++)
            {
                media = media + notas[j];
            }

            for (int j = 0; j < i; j++)
            {
                if (notas[j] > max)
                {
                    max = notas[j];
                }
                if (notas[j] < min)
                {
                    min = notas[j];
                }
            }

            Console.WriteLine($"A média das notas é: {media / i}");
            Console.WriteLine($"A maior nota é: {max}");
            Console.WriteLine($"A menor nota é: {min}");
        }
    }
}