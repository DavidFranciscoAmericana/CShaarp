using System;
using System.Globalization;

namespace ExercicioResolvido1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notatt;
            Console.WriteLine("Digite a nota 1: ");
            nota1 =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota 2: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notatt = (nota1 + nota2) ;
            Console.WriteLine("NOTA FINAL = " + notatt.ToString("F1",CultureInfo.InvariantCulture));
            if (notatt < 60)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
