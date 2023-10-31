
using System;
 class Triangulo {
    private int aAltura;
    private int aArea;
    public Triangulo () {
        this.aAltura=0;
        this.aArea=0;
    }
    public int Altura {
        set{ this.aAltura = value;}
        get {return aAltura;}
    }
    public int Area {
        set { this.aArea = value;}
        get {return aArea;}
    }
    public int CalcularBase() {
      return (this.aArea*2) / (this.aAltura*2 );
    }
}
class BaseTriangulo {
  static void Main() {
    Triangulo Figura = new Triangulo();
    string Entrada;
    string []Valores;
    Entrada=Console.ReadLine();
    Valores=Entrada.Split(' '); 
    Figura.Altura = Convert.ToInt32(Valores[0]);
    Figura.Area =Convert.ToInt32(Valores[1]);
    Console.WriteLine("{0}",Figura.CalcularBase());
  }
}
