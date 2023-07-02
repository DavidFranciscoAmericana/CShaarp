using System;
using System.Globalization;

namespace URI1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, horas;
            double valor, salario;
            n = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            salario = horas * valor;

            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
