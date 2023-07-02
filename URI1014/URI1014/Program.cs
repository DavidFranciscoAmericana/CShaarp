using System;
using System.Globalization;

namespace URI1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            double combGasto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double km = distancia / combGasto;
         
            Console.WriteLine(km.ToString("F3")+ " km/l" );
        }
    }
}
