using System;

 class DueñoPerrita {
    private int aCachorros;
    private int aHijos;
    private int aCachorrosAdoptados;
    private const int ESPOSA = 1;
    public  DueñoPerrita () {
        this.aCachorros=0;
        this.aHijos=0;
        this.aCachorrosAdoptados=0;
    }
    public DueñoPerrita (int Cachorros,int Hijos,int CachorrosAdoptados) {
        this.aCachorros=Cachorros;
        this.aHijos=Hijos;
        this.aCachorrosAdoptados=CachorrosAdoptados;
   }
    public int Cachorros  {
        get { return this.aCachorros;}
        set { this.aCachorros = value;}
    }
    public int Hijos  {
        get { return this.aHijos;}
        set { this.aHijos = value;}
    }
    public int CachorrosAdoptados  {
        get { return this.aCachorrosAdoptados;}
        set { this.aCachorrosAdoptados = value;}
    }
    public int CantidadCachorrosQueSeQuedo() {
        int CachorrosSobrantes = 0;
        CachorrosSobrantes =(this.aCachorros - this.aCachorrosAdoptados) % ( aHijos + ESPOSA  );
        return this.aCachorrosAdoptados + CachorrosSobrantes;
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
