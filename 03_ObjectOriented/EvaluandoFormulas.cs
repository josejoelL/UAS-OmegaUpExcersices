
using System;
class Formulas{
    //atributos
    private double aNumeroX;
    
    public Formulas(){
        this.aNumeroX=0.0;
    }
    public double NumeroX{
        set{this.aNumeroX=value;}
    }
    private double CalcularY(){
        return (this.aNumeroX +5)/(2*(this.aNumeroX+1));
    }
    public double CalcularZ(){
        double NumeroY=this.CalcularY();
        
        return (Math.Pow(NumeroY,2)+
        this.aNumeroX*(this.aNumeroX-2*NumeroY))
        /(this.aNumeroX*NumeroY);
    }
}
class EvaluandoFormulas{
  static void Main() {
      Formulas Calculo = new Formulas();
      Calculo.NumeroX = Convert.ToDouble(Console.ReadLine());
      
    Console.WriteLine("{0}",Calculo.CalcularZ());
  }
}