using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Vetores_exercicios2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, menor16;
            int[] idades;
            double[] pesos;
            string[] nomes;
            menor16 = 0;
            n = int.Parse(Console.ReadLine());
            idades = new int[n];
            pesos = new double[n];
            nomes = new string[n];
            double soma = 0;
            double media = 0;
            //Leitura dos dados
            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                idades[i] = int.Parse(vet[1]);
                pesos[i] = double.Parse(vet[2],CultureInfo.InvariantCulture);
            }

            //Impressao dos dados
            for (int i = 0; i < n; i++)
            {
                soma += pesos[i];
                if (idades[i] < 16)
                {
                    menor16+=1;
                }
                Console.WriteLine(nomes[i] + ' ' + idades[i].ToString() + ' ' + pesos[i].ToString("F2", CultureInfo.InvariantCulture));
            }
            //double pm16 = (double)(menor16 / n);
            media = (double)soma / n;
            double percentual = (double) menor16 / n * 100.0;
            Console.WriteLine("Média das alturas: "+media.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("% menores de 16 anos: " + percentual.ToString("F1", CultureInfo.InvariantCulture)+"%");
        }
    }
}

