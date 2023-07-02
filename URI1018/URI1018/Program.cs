using System;

namespace URI1018 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinheiro = int.Parse(Console.ReadLine());
            Console.WriteLine(dinheiro);

            int notas100 = dinheiro / 100;
            dinheiro %= 100;
            int notas50 = dinheiro / 50;
            dinheiro %= 50;
            int notas20 = dinheiro / 20;
            dinheiro %= 20;
            int notas10 = dinheiro / 10;
            dinheiro %= 10;
            int notas5 = dinheiro / 5;
            dinheiro %= 5;
            int notas2 = dinheiro / 2;
            dinheiro %= 2;
            int notas1 = dinheiro;

            
            Console.WriteLine(notas100 + " nota(s) de R$ 100,00");
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(notas2 + " nota(s) de R$ 2,00");
            Console.WriteLine(notas1 + " nota(s) de R$ 1,00");

        }
    }
}
 