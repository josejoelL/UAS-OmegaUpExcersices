using System;
 class CalulodeEnteros {
    private int aDatoA;
    private int aDatoB;
    private int aDatoC;
    public CalulodeEnteros () {
        this.aDatoA=0;
        this.aDatoB=0;
        this.aDatoC=0;
    }
    public int DatoA {
        set{ this.aDatoA = value;}
    }
    public int DatoB {
        set { this.aDatoB = value;}
    }
    public int DatoC {
        set { this.aDatoC = value;}
    }
    public string LineaSumas() {
      int Suma1 = this.aDatoA+this.aDatoB;
      int Suma2 = this.aDatoA+this.aDatoC;
      int Suma3 = this.aDatoB+this.aDatoC;
      return Suma1+" "+Suma2+" "+Suma3;
    }
    public string LineaRestas() {
      int Resta1 = this.aDatoA-this.aDatoB;
      int Resta2 = this.aDatoA-this.aDatoC;
      int Resta3 = this.aDatoB-this.aDatoC;
      return Resta1+" "+Resta2+" "+Resta3;
    }  
    public string LineaMultiplicaciones() {
      int Multiplicacion1 = this.aDatoA*this.aDatoB;
      int Multiplicacion2 = this.aDatoA*this.aDatoC;
      int Multiplicacion3 = this.aDatoB*this.aDatoC;
      return Multiplicacion1+" "+Multiplicacion2+" "+Multiplicacion3;
    }
}
class OperacionesBasicas {
  static void Main() {
    CalulodeEnteros Operaciones = new CalulodeEnteros();
    string Entrada;
    string []Valores;
    Entrada=Console.ReadLine();
    Valores=Entrada.Split(' '); 
    Operaciones.DatoA =Convert.ToInt32(Valores[0]);
    Operaciones.DatoB =Convert.ToInt32(Valores[1]);
    Operaciones.DatoC =Convert.ToInt32(Valores[2]);
    Console.WriteLine("{0}",Operaciones.LineaSumas());
    Console.WriteLine("{0}",Operaciones.LineaRestas());
    Console.WriteLine("{0}",Operaciones.LineaMultiplicaciones());
  }
}