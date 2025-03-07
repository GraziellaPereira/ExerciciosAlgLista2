using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite a quantidade de pessoas: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite a altura e sexo (M ou F)");
            double[] altura = new double[n];
            string[] sexo = new string[n];
            double maiorAltura = double.MinValue;
            double menorAltura = double.MaxValue;
            double somaAlturaM = 0;
            int somaM = 0;
            double mediaM = 0;
            int numH = 0;
            for (int i = 0; i < n; i++) {
                string[] entrada = Console.ReadLine().Split();
                altura[i] = double.Parse(entrada[0], CultureInfo.InvariantCulture);
                sexo[i] = entrada[1].ToUpper();

                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                } if (sexo[i] == "F")
                {
                    somaAlturaM += altura[i];
                    somaM++;
                } else if (sexo[i] == "M")
                {
                    numH++;
                }
            }
            mediaM = somaAlturaM / somaM;
            Console.WriteLine($"Menor altura: {menorAltura:F2}");
            Console.WriteLine($"Maior altura: {maiorAltura:F2}");
            Console.WriteLine($"Media das alturas das mulheres: {mediaM:F2}");
            Console.WriteLine($"Número de homens: {numH}");
            Console.ReadKey();
        }
    }
}
