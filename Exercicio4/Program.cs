using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite a quantidade de números que serão digitados para o cálculo da média: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite os números: ");
            string[] entrada = Console.ReadLine().Split();
            double[] numeros = new double[n];
            double somaMedia = 0;
            for (int i = 0; i < n; i++) {
                
                numeros[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
                somaMedia += numeros[i];
            }

            double media = somaMedia / n;
            Console.WriteLine($"{media:F3}".ToString(CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++) {
                if (numeros[i] < media)
                {
                    Console.WriteLine(numeros[i].ToString(CultureInfo.InvariantCulture));
                }
            }
            
            Console.ReadKey();
        }
    }
}
