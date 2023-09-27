/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Area_Triangulo {
    
    
  static void Main() {
    double Base, Altura;
    Base = Convert.ToDouble(Console.ReadLine());
    Altura = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("{0:F3}", AreaTriangulo(Base,Altura) );
  }
  
  static double AreaTriangulo(double Base, double Altura) {
      return ( Base * Altura ) / 2;
  }
  
}