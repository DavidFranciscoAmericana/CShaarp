using System;
using System.Globalization;


namespace ForEach // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] nomes;
            n = int.Parse(Console.ReadLine());
            
            nomes = new string[n];
            
            //Leitura dos dados
            for (int i = 0; i < n; i++)
            {          
                nomes[i] = Console.ReadLine();               
            }

            Console.WriteLine("Nomes lidos:");
            foreach (string nome in nomes) {
                Console.WriteLine(nome);
            }

            
        }
    }
}
