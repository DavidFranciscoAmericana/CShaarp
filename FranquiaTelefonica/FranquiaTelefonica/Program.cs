using System;
using System.Globalization;

namespace FranquiaTelefonica // Note: actual namespace depends on the project name.
{
    /*Uma operadora de telefonia cobra R$50,00 por um plano basico que da direito a 100 minutos de telefone. Cada minuto que
     exceder a franquia de 100 minutos custa R$2,00. Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu
    e mostrar o valor a ser pago.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int diferenca, minutos;
            double valor = 50.0;
            minutos = int.Parse(Console.ReadLine());
            diferenca = minutos - 100;
            if (diferenca > 0) {
                valor += diferenca * 2.0;
                Console.WriteLine("Valor a pagar = R$ "+valor.ToString("F2",CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Valor a pagar = R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
