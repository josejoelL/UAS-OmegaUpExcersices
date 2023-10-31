using System;

 class DueñoPerrita {
    private int aCantidadCachorros;
    private int aNumeroHijos;
    private int aCachorrosAdoptadosPancho;
    private const int ESPOSA = 1;
    public  DueñoPerrita () {
        this.aCantidadCachorros=0;
        this.aNumeroHijos=0;
        this.aCachorrosAdoptadosPancho=0;
    }
    public DueñoPerrita (int Cachorros,int Hijos,int CachorrosAdoptados) {
        this.aCantidadCachorros=Cachorros;
        this.aNumeroHijos=Hijos;
        this.aCachorrosAdoptadosPancho=CachorrosAdoptados;
   }
    public int Cachorros  {
        get { return this.aCantidadCachorros;}
        set { this.aCantidadCachorros = value;}
    }
    public int Hijos  {
        get { return this.aNumeroHijos;}
        set { this.aNumeroHijos = value;}
    }
    public int CachorrosAdoptados  {
        get { return this.aCachorrosAdoptadosPancho;}
        set { this.aCachorrosAdoptadosPancho = value;}
    }
    public int CantidadCachorrosQueSeQuedo() {
        int CachorrosSobrantes = 0;
        CachorrosSobrantes =(this.aCantidadCachorros - this.aCachorrosAdoptadosPancho) % ( aNumeroHijos + ESPOSA  );
        return this.aCachorrosAdoptadosPancho + CachorrosSobrantes;
    }
 }  
class RepartiendoCachorros {
  static void Main() {
    DueñoPerrita DonPancho = new DueñoPerrita();
    string Entrada;
    string []Valores;
    Entrada=Console.ReadLine();
    Valores=Entrada.Split(' '); 
    DonPancho.Cachorros=Convert.ToInt32(Valores[0]);
    DonPancho.CachorrosAdoptados=Convert.ToInt32(Valores[1]);
    DonPancho.Hijos=Convert.ToInt32(Valores[2]);
    Console.WriteLine("{0}",DonPancho.CantidadCachorrosQueSeQuedo());
  }
}
