namespace ConsoleApp.Entities;

internal class Forro
{
  public double Largura { get; set; }
  public double Comprimento { get; set; }

  public Forro() { }

  public Forro(double largura, double comprimento)
  {
    Largura = largura;
    Comprimento = comprimento;
  }
}