using System;
using System.Globalization;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos elementos terão em cada vetor: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os números separados por espaço do vetor A:");
            string[] entradaA = Console.ReadLine().Split();
            int[] numerosA = new int[n];

            Console.WriteLine("Digite os números separados por espaço do vetor B:");
            string[] entradaB = Console.ReadLine().Split();
            int[] numerosB = new int[n];


            for (int i = 0; i < n; i++)
            {
                numerosA[i] = int.Parse(entradaA[i]);
                numerosB[i] = int.Parse(entradaB[i]);

                int[] numerosC = new int[n];
                numerosC[i] = numerosA[i] + numerosB[i];
                Console.WriteLine(numerosC[i]);
            }

            Console.ReadKey();
        }
    }
}
