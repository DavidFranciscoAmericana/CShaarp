using System;
using System.Globalization;


namespace URI1011 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, pi, volume;
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            pi = 3.14159;
            volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3);
            Console.WriteLine("VOLUME = " + volume.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}