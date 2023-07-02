using System;
using System.Globalization;

namespace URI1036 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] dados = Console.ReadLine().Split(" ");
            A = int.Parse(dados[0]);
            B = int.Parse(dados[1]);
            C = int.Parse(dados[2]);

            

            if (A < B && A < C)
            {
                Console.WriteLine("MENOR = " + A);
            }
            else
            {
               if (B < C)
                {
                    Console.WriteLine("MENOR = " + B);
                }   
               else
                {
                    Console.WriteLine("MENOR = " + C);
                }
            }

        }
    }
}
