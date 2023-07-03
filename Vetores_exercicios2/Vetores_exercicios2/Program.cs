using System;
using System.Globalization;

namespace Vetores_exercicios2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;
            double total, media;
            media = 0;  
            total = 0;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];
            string[] entrada = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(entrada[i],CultureInfo.InvariantCulture);
            }
            //imprime cada posição do vetor
            for (int i = 0; i < n; i++)
            {
                 total += vet[i];
                 Console.Write(vet[i].ToString("F1",CultureInfo.InvariantCulture)+' '); 
            }
            media = total / n;
            Console.WriteLine(' ');
            Console.WriteLine(total.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
