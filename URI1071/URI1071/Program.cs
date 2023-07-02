using System;

namespace URI1071 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y,max,min,total;
            total = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if(x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }
            for (int i = min+1; i < max; i++)
            {
                if(i%2 != 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);

        }
    }
}
