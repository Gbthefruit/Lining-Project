namespace ConsoleApp.Entities;

internal class Quarto : Forro
{
  private double quantidadeDeForro;
  public double QuantidadeParafuso {get; set;}

  public Quarto() { }

  public Quarto(double largura, double comprimento) : base(largura, comprimento)
  {
    Largura = largura;
    Comprimento = comprimento;
  }

  public double Maior(double larguraForro, double comprimentoForro)
  {
    quantidadeDeForro = Largura / larguraForro;
    if (Largura < 1.90)
    {
      QuantidadeParafuso = 1;
    }
    else
    {
      QuantidadeParafuso = Largura / 1.50;
    }

    return quantidadeDeForro;
  }

  public double Menor(double larguraForro, double comprimentoForro)
  {
    quantidadeDeForro = Comprimento / larguraForro;
    if (Largura < 1.90)
    {
      QuantidadeParafuso = 1;
    }
    else
    {
      QuantidadeParafuso = Comprimento / 1.50;
    }

    return quantidadeDeForro;
  }
}
