/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
 class Triangulo {
    private int aAltura,aArea;
    
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
    public int TrianguloBase() {
      return (this.aArea*2) / this.aAltura;
    }
}


class BaseTriangulo {
    
   

  static void Main() {
    
    Triangulo Figura = new Triangulo();
  
    string Entrada;
    string []Valores;
    Entrada=Console.ReadLine();
    Valores=Entrada.Split(' '); 
    
    Figura.Altura = 2 * Convert.ToInt32(Valores[0]);
    Figura.Area =Convert.ToInt32(Valores[1]);
   
    Console.WriteLine("{0}",Figura.TrianguloBase());
   
  }
}