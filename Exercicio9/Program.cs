using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite a quantidade de mercadorias: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o produto, preço da compra e preço de venda, respectivamente (uma linha para cada produto): ");
            string[] produto = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];
            int lucroAbaixo10 = 0;
            int lucroEntre10e20 = 0;
            int lucroAcima20 = 0;
            double totalCompra = 0;
            double totalVenda = 0;
            for (int i = 0; i < n; i++) {
                string[] entrada = Console.ReadLine().Split();
                produto[i] = entrada[0];
                precoCompra[i] = double.Parse(entrada[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(entrada[2], CultureInfo.InvariantCulture);

                double lucroPercentual = ((precoVenda[i] - precoCompra[i]) / precoCompra[i]) * 100;

                if (lucroPercentual < 10)
                {
                    lucroAbaixo10++;
                }
                else if (lucroPercentual <= 20)
                {
                    lucroEntre10e20++;
                }
                else
                {
                    lucroAcima20++;
                }

                totalCompra += precoCompra[i];
                totalVenda += precoVenda[i];
            }
            double lucroTotal = totalVenda - totalCompra;

            Console.WriteLine($"\nLucro abaixo de 10%: {lucroAbaixo10}");
            Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
            Console.WriteLine($"Lucro acima de 20%: {lucroAcima20}");
            Console.WriteLine($"Valor total de compra: {totalCompra:F2}");
            Console.WriteLine($"Valor total de venda: {totalVenda:F2}");
            Console.WriteLine($"Lucro total: {lucroTotal:F2}");

            Console.ReadKey();

        }
    }
}
