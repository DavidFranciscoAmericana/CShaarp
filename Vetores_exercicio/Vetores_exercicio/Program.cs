using System;
using System.Globalization;

namespace Vetores_Exercicio // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new int[n];
            string[] entrada = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(entrada[i]);
            }
            //imprime cada posição do vetor
            for (int i = 0; i < n; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i].ToString());
                }
                
            }
        }
    }
}
