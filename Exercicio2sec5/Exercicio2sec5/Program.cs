using System;
using System.Globalization;

namespace Exercicio2sec5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, total, contador;
            double media;
            total = 0;
            contador = 0;
            entrada = int.Parse(Console.ReadLine());
            if (entrada < 0) {
                Console.WriteLine("impossivel calcular");
            }
            else
            {
                while (entrada > 0)
                {
                    total += entrada;
                    contador += 1;
                    entrada = int.Parse(Console.ReadLine());
                }
                media = (double)total / contador;
                Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
            }       

        }
    }
}
