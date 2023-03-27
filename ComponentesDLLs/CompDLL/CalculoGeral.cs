using System;

namespace CompDLL
{
  public class CalculoGeral
  {
    public int valor { get; set; }
    public int dias { get; set; }

    public int? FaturamentoMedioDiario() => valor / dias;
  }
}