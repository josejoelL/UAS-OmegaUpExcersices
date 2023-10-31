/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Area_Cilindro {
    
    
  static void Main() {
    double Radio, Altura;
    Radio = Convert.ToDouble(Console.ReadLine());
    Altura = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("AREA={0:F2}", AreaCilindro(Radio,Altura) );
    Console.WriteLine("VOLUMEN={0:F2}", VolumenCilindro(Radio,Altura) );
  }
  
  static double AreaCilindro(double Radio, double Altura) {
     double Pi=3.1416;
      return 2*Pi* ( Radio * Altura ) + 2*Pi*(Math.Pow(Radio,2));
  }
  static double VolumenCilindro(double Radio, double Altura) {
     double Pi=3.1416;
      return Pi * (Math.Pow(Radio,2)) * Altura;
  }
  
}