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
            List<Pijama> pijama = new List<Pijama>(); 
            int i = 0;
            string stringTemp;
            float floatTemp;

            while (i != 4)
            {
                Console.WriteLine("\nMenu Pijamas");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Remover");
                Console.WriteLine("4 - Sair");
                Console.Write("Digite a opção desejada: ");

                if (!int.TryParse(Console.ReadLine(), out i) && i > 0 && i < 5)
                {
                    Console.WriteLine("\nOpção inválida");
                    continue;
                }


                switch (i)
                {
                    case 1:
                        Pijama p = new Pijama();

                        Console.Write("\nDigite o Tamanho entre P, M e G: ");
                        stringTemp = Console.ReadLine().ToLower();

                        while (string.IsNullOrWhiteSpace(stringTemp))
                        {
                            Console.WriteLine("Tamanho não pode ser vazio, digite o Tamanho entre P, M e G");
                        }

                        while (stringTemp != "p" || stringTemp != "m" || stringTemp != "g")
                        {
                            Console.Write("Tamanho inválido, digite o Tamanho entre P, M e G: ");
                        }
                        p.tamanho = stringTemp.ToUpper();

                        /*while (true)
                        {
                            Console.Write("\nDigite o Tamanho entre P, M e G: ");
                            stringTemp = Console.ReadLine().ToLower();

                            if (string.IsNullOrWhiteSpace(stringTemp))
                            {
                                Console.WriteLine("Tamanho não pode ser vazio");
                                continue;
                            }

                            if (stringTemp != "p" || stringTemp != "m" || stringTemp != "g")
                            {
                                Console.Write("Tamanho inválido, digite o Tamanho entre P, M e G: ");
                                continue;
                            }
                            p.tamanho = stringTemp.ToUpper();
                            break;
                        }*/

                        Console.Write("Digite o nome da estampa: ");
                        stringTemp = Console.ReadLine();

                        while (string.IsNullOrWhiteSpace(stringTemp))
                        {
                            Console.WriteLine("Estampa não pode ser vazio, digite o nome da estampa: ");
                        }
                        p.estampa = stringTemp;


                        /*
                        while (true)
                        {
                            Console.Write("Digite o nome da estampa: ");
                            stringTemp = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(stringTemp))
                            {
                                Console.WriteLine("Estampa não pode ser vazia");
                                continue;
                            }
                            p.estampa = stringTemp;
                            break;
                        }*/

                        Console.WriteLine("Digite o valor: ");
                        while (!float.TryParse(Console.ReadLine(), out floatTemp))
                        {
                            Console.WriteLine("Opção inválida, digite o valor:");
                        }
                        p.valor = floatTemp;

                        Console.WriteLine("Pijama cadsatrado com sicesso?!");
                    break;

                    case 2:
                        foreach (Pijama temp in pijama)
                        {
                            Console.WriteLine($"\nPijama número: {pijama.Count}");
                            Console.WriteLine($"Estampa: {temp.estampa}")   ;
                            Console.WriteLine($"Tamanho: {temp.tamanho}");
                            Console.WriteLine($"Valor: {temp.valor}");
                        }
                    break;

                }
            }
        }
    }
}
