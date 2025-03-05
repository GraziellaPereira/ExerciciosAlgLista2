using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite a quantidade de números que serão lidos para o cálculo da média dos números pares que forem lidos: ");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("Agora digite os números: ");
            string[] entrada = Console.ReadLine().Split();
            int[] numeros = new int[n];
            int somaMedia = 0;
            int nPar = 0;
            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(entrada[i], CultureInfo.InvariantCulture);

                if (numeros[i] % 2 == 0) {
                    somaMedia += numeros[i];
                    nPar++;
                        }
                
            }

            double media = somaMedia / nPar;
            Console.WriteLine($"{media:F2}".ToString(CultureInfo.InvariantCulture));
        }
    }
}
