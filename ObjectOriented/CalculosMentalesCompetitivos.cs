/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class CalculosMentalesCompetitivos {
  
   class SecuenciaOperaciones {
    private float aInicial;
    
    public SecuenciaOperaciones () {
        this.aInicial=0.0f;
    } 
      public float Inicial  {
        set { this.aInicial = value;}
        get {return this.aInicial; }
    }
    public float CantidadMasCinco() {
      return (float) (this.aInicial + 5.0f ) ;
    }
     public float CantidadAlCuadrado() {
      return (float) Math.Pow(this.CantidadMasCinco(),2.0f );
    }
     public float CantidadDivididaPorUnTercioDelInicial() {
      return (float) this.CantidadAlCuadrado() / (this.aInicial/3.0f);
    }
      public float CantidadAlCubo() {
      return (float) Math.Pow(this.CantidadDivididaPorUnTercioDelInicial(),3.0f );
    }
   }
  static void Main() {
    
    SecuenciaOperaciones Operacion = new SecuenciaOperaciones(); 
    Operacion.Inicial = float.Parse(Console.ReadLine());
    
    Console.WriteLine("{0:F6}",Operacion.Inicial);
    Console.WriteLine("{0:F6}",Operacion.CantidadMasCinco());
    Console.WriteLine("{0:F6}",Operacion.CantidadAlCuadrado());
    Console.WriteLine("{0:F6}",Operacion.CantidadDivididaPorUnTercioDelInicial());
    Console.WriteLine("{0:F6}",Operacion.CantidadAlCubo());
  }
}