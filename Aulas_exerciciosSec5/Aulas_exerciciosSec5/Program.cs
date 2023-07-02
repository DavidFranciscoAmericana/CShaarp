using System;

namespace ForRepeticao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, number, total;
            total = 0;
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                total += number;
            }
            Console.WriteLine(total);
        }
    }
}
