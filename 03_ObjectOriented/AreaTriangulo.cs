/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
 class Triangulo {
    private double aBase,aAltura;
    
    public Triangulo() {
        this.aBase=0.0;
        this.aAltura=0.0;
    }
    public Triangulo(double Base, double Altura) {
        this.aBase=Base;
        this.aAltura=Altura;
    }
    public double Base {
        set{this.aBase=value;}
    }
    public double Altura {
        set{this.aAltura=value;}
    }
    
    public double Area(){
        return (this.aBase * this.aAltura)/2;
        
    }
}
class AreaTriangulo {


  static void Main() {
    Triangulo Figura = new Triangulo();
    Figura.Base = Convert.ToDouble(Console.ReadLine());
    Figura.Altura = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("{0:F3}",Figura.Area());
    
  }
}