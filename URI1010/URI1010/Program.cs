using System;
using System.Globalization;

namespace URI1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod, qde;
            double pagar1, valor, pagar2, total; 
            string[] dados1 = Console.ReadLine().Split();
            cod = int.Parse(dados1[0]);
            qde = int.Parse(dados1[1]);
            valor = double.Parse(dados1[2],CultureInfo.InvariantCulture);
            pagar1 = valor * qde;
            string[] dados2 = Console.ReadLine().Split();
            cod = int.Parse(dados2[0]);
            qde = int.Parse(dados2[1]);
            valor = double.Parse(dados2[2], CultureInfo.InvariantCulture);
            pagar2 = valor * qde;
            total = pagar1 + pagar2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}
