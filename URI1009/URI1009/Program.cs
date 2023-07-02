using System;
using System.Globalization;


namespace URI1009 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, vendas, premio,tt;
            string nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            premio = vendas * 0.15;
            tt = premio + salario;
            Console.WriteLine("TOTAL = R$ " + tt.ToString("F2"),CultureInfo.InvariantCulture);
            
        }
    }
}