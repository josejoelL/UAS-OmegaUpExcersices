using System;
    class RepartoDulces {
    private int aDulces;
    private int aAmigos;
    public  RepartoDulces () {
        this.aDulces=0;
        this.aAmigos=0;
    }
    public int Amigos  {
        set { this.aAmigos = value;}
    }
    public int Dulces  {
        set { this.aDulces = value;}
    }
    public int DulcesCumpleanero() {
      return Sobras() % this.aAmigos ;
    }
      public int Sobras() {
      return (this.aDulces - MitadTia()) ;
    }
    public int MitadTia() {
      return this.aDulces/2 ;
    }
}
class CuantosDulcesMeTocaran{
  static void Main() {
    RepartoDulces Cumpleanero = new RepartoDulces();
    string Entrada;
    string []Valores;
    Entrada=Console.ReadLine();
    Valores=Entrada.Split(' '); 
    Cumpleanero.Dulces=Convert.ToInt32(Valores[0]);
    Cumpleanero.Amigos=Convert.ToInt32(Valores[1]);
    Console.WriteLine("{0}",Cumpleanero.DulcesCumpleanero());
   
  }
}