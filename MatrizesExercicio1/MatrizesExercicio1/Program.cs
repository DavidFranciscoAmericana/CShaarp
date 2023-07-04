using System;

namespace MatrizesExercicio1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração da matriz
            int[,] matrizA;

            //instanciando a matrizA
            int linhas, colunas;
            int n = int.Parse(Console.ReadLine());
            linhas = n;
            colunas = n;
            int negativos = 0;
            matrizA = new int[linhas, colunas];

            //recebendo a leitura da linha
            //for i percorre linha e for j percorre coluna
            for (int i = 0; i < linhas; i++)
            {
                string[] vet = Console.ReadLine().Split();
                for (int j = 0; j < colunas; j++)
                {
                    matrizA[i, j] = int.Parse(vet[j]);
                    if (matrizA[i, j] < 0)
                    {
                        negativos++;
                    }
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL:");
            //Percorrendo a matrizA para mostrar o conteudo
            for (int i = 0; i < linhas; i++)
            {              
                    Console.Write(matrizA[i, i] + " ");             
            }
            Console.WriteLine("Numeros negativos: " + negativos);
        }
    }
}
