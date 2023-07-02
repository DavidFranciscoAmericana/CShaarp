using System;

namespace URI1020 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            

            int anos = idade / 365;
            idade %= 365;
            int meses = idade / 30;
            idade %= 30;
            int dias = idade;
            

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            
        }
    }
}
