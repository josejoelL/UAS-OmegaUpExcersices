/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class RestaBasica  {
  static void Main() {
    string Entrada;
    string []Valores;
    int Numero1, Numero2;
    int Resta;
    Entrada=Console.ReadLine();
    Valores=Entrada.Split(' '); 
    Numero1=Convert.ToInt32(Valores[0]);
    Numero2=Convert.ToInt32(Valores[1]);
    Resta=Numero1-Numero2;
    Console.Write(Resta);
  
  }
}