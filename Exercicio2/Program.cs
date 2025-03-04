using System;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números que serão digitados: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os números separados por espaço:");

            string[] entrada = Console.ReadLine().Split();
            int[] numeros = new int[n];

            int qtd = 0;

            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(entrada[i], CultureInfo.InvariantCulture);

                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine(numeros[i]);
                    qtd++;
                }
            }

            Console.WriteLine(qtd);
            Console.ReadKey();
        }
    }
}
