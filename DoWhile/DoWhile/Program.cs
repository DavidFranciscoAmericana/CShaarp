using System;
using System.Globalization;

namespace DoWhile // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double fahrenheit, celsius;
            string resp;
    
            do
            {
                Console.WriteLine("Entre com a temperatura em graus Celsius: ");
                celsius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                fahrenheit = ((celsius * 9) / 5) + 32;
                Console.WriteLine(celsius + " equivale à " + fahrenheit.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir? s/n");
                resp = Console.ReadLine().ToUpper();
            } while (resp == "S");

        }
    }
}
