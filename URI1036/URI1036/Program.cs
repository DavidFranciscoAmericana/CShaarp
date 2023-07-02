using System;
using System.Globalization;

namespace URI1036 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta,r1,r2;
            string[] dados = Console.ReadLine().Split(" ");
            A = double.Parse(dados[0], CultureInfo.InvariantCulture);
            B = double.Parse(dados[1], CultureInfo.InvariantCulture);
            C = double.Parse(dados[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2.0) - 4 * A * C;

            if (A == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else 
            {
                r1 = (- B + Math.Sqrt(delta)) / (2.0 * A);
                r2 = (- B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine("R1 = " +  r1.ToString("F5",CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " +  r2.ToString("F5", CultureInfo.InvariantCulture));
            }
           
        }
    }
}