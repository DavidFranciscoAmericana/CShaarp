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
            string[] n = Console.ReadLine().Split();
            linhas = int.Parse(n[0]);
            colunas = int.Parse(n[1]);
            
            matrizA = new int[linhas, colunas];
            
            //recebendo a leitura da linha
            //for i percorre linha e for j percorre coluna
            for (int i = 0; i < linhas; i++)
            {
                string[] vet = Console.ReadLine().Split();
                for (int j = 0; j < colunas; j++)
                {
                    matrizA[i, j] = int.Parse(vet[j]);
    
                }
            }
            //atribuindo a soma no vetor
            int[] somas = new int[linhas];
            //Percorrendo a matrizA 
            for (int i = 0; i < linhas; i++)
            {
                int soma = 0;
                for (int j = 0;j < colunas; j++)
                {
                    soma += matrizA[i, j];
                }
                somas[i] = soma;
            }

            foreach (int soma in somas) {
                Console.WriteLine(soma);
            }

            
            
        }
    }
}
