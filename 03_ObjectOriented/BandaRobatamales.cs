/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class BandaRobatamales {
    
    class Banda {
    private int aMiembros,aTamales;
    
    
    public  Banda () {
        this.aMiembros=0;
        this.aTamales=0;
    }
  
    public int Miembros  {
        set { this.aMiembros = value;}
    }
    public int Tamales  {
        set { this.aTamales = value;}
    }
    
    public int TamalesLider() {
      return MitadDelLider() + ( Sobras() % MiembrosRestantes() );
    }
    
    public int MitadDelLider() {
      return this.aTamales/2 + aTamales%2 ;
    }
       public int Sobras() {
      return (this.aTamales - MitadDelLider()) ;
    }
        public int MiembrosRestantes() {
      return this.aMiembros-1 ;
    }
    public int RepartoEquitativo() {
      return (this.aTamales - MitadDelLider()) / (this.aMiembros-1) ;
    }
}

  static void Main() {
    
    Banda Robatamales = new Banda();
  
    string Entrada;
    string []Valores;
    Entrada=Console.ReadLine();
    Valores=Entrada.Split(' '); 
    
    Robatamales.Tamales=Convert.ToInt32(Valores[0]);
    Robatamales.Miembros=Convert.ToInt32(Valores[1]);
   
    Console.WriteLine("{0}",Robatamales.TamalesLider());
   
  }
}