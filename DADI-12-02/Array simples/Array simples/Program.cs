using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[3];
            notas[0] = 4;
            notas[1] = 6;
            notas[2] = 7;

            Console.WriteLine("A nota 1: " + notas[0]);
            Console.WriteLine("A nota 2: " + notas[1]);
            Console.WriteLine("A nota 3: " + notas[2]);
        }
    }
}
