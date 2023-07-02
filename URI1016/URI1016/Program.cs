using System;
using System.Globalization;

namespace URI1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int car1, car2, tempo, distancia;
            car1 = 60;
            car2 = 90;
            tempo = 2;
            distancia = int.Parse(Console.ReadLine());
            Console.WriteLine((tempo * distancia) + " minutos");
        }
    }
}
