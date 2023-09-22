/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class convertirDolares {
  static void Main() {
    int EntradaDolar, EntradaPesos;
    
     EntradaDolar = Convert.ToInt32(Console.ReadLine());
     EntradaPesos = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(EntradaDolar*EntradaPesos);
  }
}