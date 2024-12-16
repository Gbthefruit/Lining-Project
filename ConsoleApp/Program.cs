namespace ConsoleApp;

using System.Globalization;
using Entities;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Qual o comprimento do quarto? ");
    double comprimento = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Qual a largura do quarto? ");
    double largura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Quarto quarto = new Quarto(largura, comprimento);

    Console.Write("Qual o sentido que o forro será colocado? (MAIOR/MENOR): ");
    string sentido = Console.ReadLine()!.ToUpper();
    Console.WriteLine();
    if (sentido == "MAIOR")
    {
      Console.WriteLine($"{quarto.Maior(0.20, 7.00)} forros serão necessários para preencher o quarto.\nE serão necessários {quarto.QuantidadeParafuso:f1} parafusos");
    }
    else if (sentido == "MENOR")
    {
      Console.WriteLine($"{quarto.Menor(0.20, 7.00)} forros serão necessários para preencher o quarto.\nE serão necessários {quarto.QuantidadeParafuso:f1} parafusos");
    }
  }
}
