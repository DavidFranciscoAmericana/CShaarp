using System;
using System.Globalization;
/*1002".*/

namespace PrimeiroProblemaURI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, n, raio;
            n = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = n * (raio * raio);
            
            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}
