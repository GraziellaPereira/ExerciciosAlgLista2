using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite a quantidade de alunos que serão digitados: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite respectivamente o nome do aluno, sua nota no primeiro semestre e sua nota no segundo semestre (em cada linha deve conter o nome do aluno e suas notas): ");
            string[] aluno = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];
            double[] media = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split();
                aluno[i] = entrada[0];
                nota1[i] = double.Parse(entrada[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(entrada[2], CultureInfo.InvariantCulture);

                media[i] = ((nota1[i] + nota2[i]) / 2);


            }
            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0; i < n; i++) {
                if (media[i] >= 6)
                {
                    Console.WriteLine(aluno[i]);
                }
            }

           

            Console.ReadKey();
        }
    }
}
