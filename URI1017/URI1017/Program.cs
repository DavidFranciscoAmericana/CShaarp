using System;
using System.Globalization;

namespace URI1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int consumo, distancia, tempo, velocidade;
            consumo = 12;
            tempo = int.Parse(Console.ReadLine());
            distancia = int.Parse(Console.ReadLine());
            double kmGasto = (double)(tempo * distancia)/consumo;
            Console.WriteLine(kmGasto.ToString("F3"),CultureInfo.InvariantCulture);
        }
    }
}
