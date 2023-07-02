using System;
using System.Globalization;

namespace PrimeiroPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAÇÃO DE VARIAVEIS 
            int num1, num2;
            string usuario = "David Francisco";
            double x = 10.3658454;

            //SAIDAS GERAIS
            Console.WriteLine(usuario + " said: Hello World!");
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu troco é " + x + " reais");
            Console.WriteLine("Seu troco é " + x.ToString("F2") + " reais");
            Console.WriteLine("Seu troco é " + x.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            //OPERAÇÕES ARITMETICAS BASICAS
            num1 = 11;
            num2 = 5;
            int soma = num1 + num2; 
            int subtracao = num1 - num2;
            int multiplicacao = num1 * num2;
            double divisao = (double)num1 / num2;//Casting
            int resto = num1 % num2;
            //IMPRESSÃO DO RESULTADO
            Console.WriteLine("Operações com os numeros " + num1 + " e " + num2);
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Multiplicação: " + multiplicacao);
            Console.WriteLine("Divisão: " + divisao);
            Console.WriteLine("Resto da divisão: " + resto);

            //COMANDO DE ENTRADA DE DADOS PELO TECLADO Console.Readline()
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);

            //COMANDO Split FATIANDO UMA FRASE E ALOCANDO CADA PALAVRA EM UMA VARIAVEL
            Console.Write("Digite três cores do semaforo: ");
            
            string[] cores = Console.ReadLine().Split(' ');
            string cor1 = cores[0];
            string cor2 = cores[1];
            string cor3 = cores[2];
            Console.WriteLine("Cores do semaforo: ");
            Console.WriteLine(cor1);
            Console.WriteLine(cor2);
            Console.WriteLine(cor3);
        }
    }
}
