using System.Globalization;

namespace FuncoesMatematicas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funções matemáticas");
            Console.Write("Entre com o valor de x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Entre com o valor de y: ");
            int y = int.Parse(Console.ReadLine());

            //FUNÇOES MATEMATICAS
            double raiz, potencia, absoluto;
            raiz = Math.Sqrt(x);
            potencia = Math.Pow(x, y);
            absoluto = Math.Abs(y - x);

            //IMPRESSAO
            Console.WriteLine("Raiz: " + raiz +
                              "\nPotencia: "+potencia+
                              "\nAbsoluto: "+absoluto);

            Console.WriteLine("");
            Console.WriteLine("EXERCICIO");
            Console.WriteLine("");
            Console.WriteLine("Fazer um programa para ler as medidas da largura e comprimento de um terreno " +
                              "retangular com uma casa decimal, bem como o valor do metro quadrado do terreno " +
                              "com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do " +
                              "terreno, bem como o valor do preço do terreno, ambos com duas casas decimais," +
                              "conforme abaixo: ");
            //Declarando as variaveis
            double larg, comp, valorMetro, area, preco;
            Console.Write("Largura: ");
            larg = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Comprimento: ");
            comp = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Valor por metro²: R$");
            valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //CALCULOS
            area = larg * comp;
            preco = area * valorMetro;

            Console.WriteLine("Area: "+area.ToString("F2")+"\nPreço do terreno: R$"+preco.ToString("F2"));



        }
    }
}
