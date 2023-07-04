using System;

namespace Matrizes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração da matriz
            int[,] matrizA;

            //instanciando a matrizA
            int linhas, colunas;
            string[] vetln = Console.ReadLine().Split(' ');
            linhas = int.Parse(vetln[0]);
            colunas = int.Parse(vetln[1]);    

            matrizA = new int[linhas, colunas];

            //recebendo a leitura da linha
            //for i percorre linha e for j percorre coluna
            for(int i = 0;i<linhas;i++)
            {
                string[] vet = Console.ReadLine().Split();
                for(int j = 0; j < colunas; j++)
                {
                    matrizA[i,j] = int.Parse(vet[j]);
                }
            }

            //Percorrendo a matrizA para mostrar o conteudo
            for (int i = 0;i< linhas;i++)
            {
                for(int j = 0;j < colunas; j++)
                {
                    Console.Write(matrizA[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
