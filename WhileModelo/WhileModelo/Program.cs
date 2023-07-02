using System;

namespace WhileModelo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, total;
            total = 0;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                total += n;
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(total);
        }
    }
}