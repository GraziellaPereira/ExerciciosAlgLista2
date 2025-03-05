using System;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números que serão digitados: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os números separados por espaço:");

            string[] entrada = Console.ReadLine().Split();
            double[] numeros = new double[n];

            double maiorNumero = double.MinValue;
            int posicao = 0;

            for (int i = 0; i < n; i++)
            {
                numeros[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);

                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maiorNumero.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
            Console.ReadKey();
        }
    }
}