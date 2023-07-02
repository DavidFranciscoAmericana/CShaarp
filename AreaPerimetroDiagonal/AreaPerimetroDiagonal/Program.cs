using System;
using System.Globalization;

namespace AreaPerimetroDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Base, Altura, Area, Perimetro, Diagonal;

            Console.Write("Base: ");
            Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = Base * Altura;
            Perimetro = 2 * (Base + Altura);
            Diagonal = Math.Sqrt(Math.Pow(Base,2.0) + Math.Pow(Altura,2.0));
            Console.WriteLine("Area = " + Area.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Perimetro = " + Perimetro.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Diagonal = " + Diagonal.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}