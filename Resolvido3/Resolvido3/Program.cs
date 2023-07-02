using System;
using System.Globalization;
namespace Resolvido3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id1, id2;
            string nome1, nome2;
            string[] vet;

            vet = Console.ReadLine().Split(" ");
            nome1 = vet[0];
            id1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(" ");
            nome2 = vet[0];
            id2 = int.Parse(vet[1]);

            double media = (double)(id1 + id2) / 2;
            Console.WriteLine("A idade média de "+nome1+" e " + nome2 +" é de "+media.ToString("F1", CultureInfo.InvariantCulture) +" anos");
        }
    }
}