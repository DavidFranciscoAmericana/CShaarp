using System;

namespace SwitchCase // Note: actual namespace depends on the project name.
{
    /*Fazer um programa para ler um valor de 1 a 7 representando um dia da semana (sendo 1 = domingo, 2 = segunda) */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] diaE = { "domingo", "segunda", "terça", "quarta","quinta", "sexta","sabado" };
            int dia = int.Parse(Console.ReadLine());
            string saida;
            
            switch (dia)
            {
                case 1:
                    saida = diaE[0]; 
                    break;
                case 2:
                    saida = diaE[1];
                    break;
                case 3:
                    saida = diaE[2];
                    break;
                case 4:
                    saida = diaE[3];
                    break;
                case 5:
                    saida = diaE[4];
                    break;
                case 6:
                    saida = diaE[5];
                    break;
                case 7:
                    saida = diaE[6];
                    break;
                default:
                    saida = "Valor invalido";
                    break;
            }
            Console.WriteLine("Dia da semana: " + saida);
        }
    }
}