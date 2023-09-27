/******************************************************************************

@Jose Joel landeros santos

*******************************************************************************/
using System;
class Repartiendo_Cachorros {
    
    class DueñoPerrita {
    private int cachorros,hijos,cachorrosAdoptados;
    private const int ESPOSA = 1;
    
    public  DueñoPerrita () {
        this.cachorros=0;
        this.hijos=0;
        this.cachorrosAdoptados=0;
    }
  
    public DueñoPerrita (int Cachorros,int Hijos,int CachorrosAdoptados) {
        this.cachorros=Cachorros;
        this.hijos=Hijos;
        this.cachorrosAdoptados=CachorrosAdoptados;
   }
    public int Cachorros  {
        get { return this.cachorros;}
        set { this.cachorros = value;}
    }
    public int Hijos  {
        get { return this.hijos;}
        set { this.hijos = value;}
    }
    public int CachorrosAdoptados  {
        get { return this.cachorrosAdoptados;}
        set { this.cachorrosAdoptados = value;}
    }
    
    public int CantidadCachorrosQueSeQuedo() {
        int CachorrosSobrantes = 0;
     
          CachorrosSobrantes =   (this.cachorros - this.cachorrosAdoptados) % ( Hijos + ESPOSA  )   ;
        return this.cachorrosAdoptados + CachorrosSobrantes;
         
     
       
           
    }
}

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