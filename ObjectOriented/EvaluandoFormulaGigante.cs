using System;
    class CaluladoraFormulas {
    private double aValorX;
    private double aValorY;
    private double aValorZ;
    public  CaluladoraFormulas () {
        this.aValorX=0.0d;
        this.aValorY=0.0d;
        this.aValorZ=0.0d;
    }
    public double ValorX  {
        set { this.aValorX = value;}
    }
     public double ValorY  {
        set { this.aValorY = value;}
    }
     public double ValorZ  {
        set { this.aValorZ = value;}
    }
      public double Resultado()  {
       return (ParteUno()*ParteDos())/(ParteTres()+ParteCuatro());
    }
    public double ParteUno()  {
       return ( (2*this.aValorX) +this.aValorY)/( this.aValorZ ) ;
    }
    public double ParteDos()  {
       return (Math.Pow(this.aValorY,3) - this.aValorZ );
    }
    public double ParteTres()  {
       return (this.aValorX + (2*this.aValorY) + (3*this.aValorZ) )/(this.aValorZ-(2*this.aValorY) -(3*this.aValorX));
    }
    public double ParteCuatro()  {
       return ( Math.Pow(this.aValorX,2) + Math.Pow(this.aValorZ,2) );
    }
}
class EvaluandoFormulaGigante{
  static void Main() {
    CaluladoraFormulas Calculo = new CaluladoraFormulas();
    string Entrada;
    string []Valores;
    Entrada=Console.ReadLine();
    Valores=Entrada.Split(' '); 
    Calculo.ValorX=Convert.ToDouble(Valores[0]);
    Calculo.ValorY=Convert.ToDouble(Valores[1]);
    Calculo.ValorZ=Convert.ToDouble(Valores[2]);
    Console.WriteLine("{0:F6}",Calculo.Resultado());
  }
}