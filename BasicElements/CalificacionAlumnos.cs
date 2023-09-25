/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class CalificacionAlumnos {
  static void Main() {
    int EntradaExamen, EntradaAsistencia, EntradaTareas;
    
     EntradaExamen = Convert.ToInt32(Console.ReadLine());
     EntradaAsistencia = Convert.ToInt32(Console.ReadLine());
     EntradaTareas = Convert.ToInt32(Console.ReadLine());
     
    Console.WriteLine( ((EntradaExamen*60)+(EntradaAsistencia*20)+(EntradaTareas*20))/100 );
    
    
  }
}