/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Cuadrado {
private int lado;
    
    
  public  Cuadrado () {
  this.lado=0;
  }
   public  Cuadrado (int pLado) {
    this.lado=pLado;
   }
    public int Lado  {
    get { return this.lado;}
    set { this.lado = value;}
    }
    public int Area() {
       return this.lado*this.lado;
    }
    public int Perimetro() {
        return this.lado+this.lado+this.lado+this.lado;
    }
}

class SuperficieContorno {
  static void Main() {
   
   Cuadrado Figura= new Cuadrado();
   Figura.Lado=Convert.ToInt32(Console.ReadLine());
   
   Console.WriteLine("Superficie: {0}",Figura.Area());
   Console.Write("Contorno: {0}",Figura.Perimetro());
   
   
   
   
  }
}