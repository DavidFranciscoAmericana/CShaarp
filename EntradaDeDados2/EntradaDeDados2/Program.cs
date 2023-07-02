using System;
using System.Globalization;

namespace EntradaDeDados2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA DE DADOS NO CONSOLE
            Console.Write("Digite o código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o genero: ");
            char genero = char.Parse(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //IMPRESSÃO DO QUE FOI DIGITADO ACIMA
            Console.WriteLine("Dados digitados acima: ");
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Sexo: " + genero);
            Console.WriteLine("Peso: "+peso);
            Console.WriteLine("Altura: " + altura);

            //OUTRA FORMA DE FAZER DIGITANDO TUDO NA MESMA LINHA SEPARARA POR " "
            Console.WriteLine("Entre com codigo nome idade sexo peso e altura");
            string[] entrada = Console.ReadLine().Split(' ');
            int cod = int.Parse(entrada[0]);
            string nom = entrada[1];
            int ida = int.Parse(entrada[2]);
            string sex = entrada[3];
            double pes = double.Parse(entrada[4], CultureInfo.InvariantCulture);
            double alt = double.Parse(entrada[5], CultureInfo.InvariantCulture);

            //IMPRIMINDO O QUE FOI DIGITADO
            Console.WriteLine("Dados digitados acima: ");
            Console.WriteLine("Código: " + cod);
            Console.WriteLine("Nome: " + nom);
            Console.WriteLine("Idade: " + ida);
            Console.WriteLine("Sexo: " + sex);
            Console.WriteLine("Peso: " + pes);
            Console.WriteLine("Altura: " + alt);

        }
    }
}
