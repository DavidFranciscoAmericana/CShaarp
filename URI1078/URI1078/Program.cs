using System;

namespace URI1078 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(number+" x " + i +" = " + number*i);
            }

        }
    }
}
