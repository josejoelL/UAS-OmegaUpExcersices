using System;
    class CalculadoraCientifica {
    private double aValorX;
    public  CalculadoraCientifica () {
        this.aValorX=0.0d;
    }
    public double ValorX  {
        set { this.aValorX = value;}
    }
      public double ResultadoY()  {
       return ( DivicionRepetida()+ this.aValorX )*( DivicionRepetida() / ( DivicionRepetida() + (this.aValorX*2)  ) );
    }
     public double DivicionRepetida()  {
       return ((this.aValorX  + Math.Pow(this.aValorX ,2)) / ((this.aValorX * 5) + 3)) ;
    }
}
class PorquePodemosProgramar{
  static void Main() {
    CalculadoraCientifica Calculo = new CalculadoraCientifica();
    Calculo.ValorX = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("{0:F6}",Calculo.ResultadoY());
  }
}