using System;
using System.Globalization;
namespace PrimeiroExercico // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para executar a seguinte interação com o\n" +
                              "usuario, lendoos valores destacados em vermelho, e depois\n" +
                              "mostrar os dados na tela");
            //Entrada de dados
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor da sua casa: ");
            double valorCasa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade, altura (na mesma linha))");
            string[] dados = Console.ReadLine().Split(' ');
            string lastName = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

            //SAIDA DE DADOS
            Console.WriteLine("Nome: "+nome+
                              "\nNúmero quartos: "+quartos+
                              "\nValor do Imóvel: "+valorCasa+
                              "\nÚltimo nome: "+lastName+", idade "+idade+" e altura "+altura
                               );
        }
    }
}
