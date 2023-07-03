using System;

namespace Vetores // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação de vetores
            string[] nomes;
            int[] idades;
            double[] peso;

            //Instanciando os vetores
            nomes = new string[5]; 
            idades = new int[5];
            peso = new double[5];

            //Acessando vetores
            nomes[0] = "David";
            idades[0] = 44;
            peso[0] = 88.2;

            //Escreve no console
            Console.WriteLine(nomes[0]+" " + idades[0] + " " + peso[0]);

        }
    }
}
