namespace ConsoleApp.Entities;

internal class Quarto : Forro
{
  private double quantidadeDeForro;
  public double QuantidadeMetalon {get; set;}
  public double QuantidadeParafuso { get; set; }

  public Quarto() { }

  public Quarto(double largura, double comprimento) : base(largura, comprimento)
  {
    Largura = largura;
    Comprimento = comprimento;
  }

  public double Maior(double larguraForro, double comprimentoForro)
  {
    quantidadeDeForro = Largura / larguraForro;
    if (Largura < 1.50)
    {
      QuantidadeMetalon = 1;
      QuantidadeParafuso = QuantidadeMetalon * 3;
    }
    else
    {
      QuantidadeMetalon = Largura / 1.50;
      QuantidadeParafuso = QuantidadeMetalon * 3;
    }

    return quantidadeDeForro;
  }

  public double Menor(double larguraForro, double comprimentoForro)
  {
    quantidadeDeForro = Comprimento / larguraForro;
    if (Largura < 1.50)
    {
      QuantidadeMetalon = 1;
      QuantidadeParafuso = QuantidadeMetalon * 3;
    }
    else
    {
      QuantidadeMetalon = Comprimento / 1.50;
      QuantidadeParafuso = QuantidadeMetalon * 3;
    }

    return quantidadeDeForro;
  }
}
