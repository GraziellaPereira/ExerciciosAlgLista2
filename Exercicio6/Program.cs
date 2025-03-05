using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite a quantidade de pessoas que serão informadas: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da pessoa e na frente a sua idade (uma pessoa e idade separados por espaço e por linha): ");
            string[] nome = new string[n];
            int[] idade = new int[n];
            int maiorIdade = 0;
            string maisVelho = "x";
            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split();
                nome[i] = entrada[0];
                idade[i] = int.Parse(entrada[1]);

                if (idade[i] > maiorIdade)
                {
                    maiorIdade = idade[i];
                    maisVelho = nome[i];
                }
            }
            Console.WriteLine("Pessoa mais velha: " + maisVelho);
            Console.ReadKey();
        }
    }
}
