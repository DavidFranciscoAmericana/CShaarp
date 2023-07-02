using System;
using System.Globalization;


namespace URI1015 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, h, m, s, resto;
            n = int.Parse(Console.ReadLine());
            h = n / 3600;
            resto = n% 3600;
            m = resto / 60;
            resto = resto % 60;
            s = resto;
            Console.WriteLine(h+":"+m+":"+s);
        }
    }


}