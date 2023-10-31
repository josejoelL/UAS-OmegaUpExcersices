using System;
class OperacionMatriz {
    private int aReglones;
       private int aColumnas;
       public int [,] aArreglo;
       public OperacionMatriz (){
        this.aReglones=100;
        this.aColumnas=100;
        this.aArreglo=new int [this.aReglones,this.aColumnas];
       }
       public int TotalReglones{
           set{  this.aReglones=value;}
           get{  return this.aReglones; }
       }
        public int TotalColumnas{
           set{this.aColumnas=value; }
           get{ return this.aColumnas; }
       }
       public int [,] Arreglo{
           set {this.aArreglo=value;}
       }
       public string AnalizarDiagonales(){
           string Respuesta = "Iguales";
           
           for(int r=0,  c= this.aColumnas-1; r<this.aReglones; r++,c--){
               if (this.aArreglo[r,r] != this.aArreglo[r,c]){
                   Respuesta = "No iguales";
                   break;
               }
           }
           return Respuesta;
       }
       
}


class DiagonalesIguales {
  static void Main() {
      
      OperacionMatriz Objeto = new OperacionMatriz();
      int TamañoN;
      TamañoN = Convert.ToInt32(Console.ReadLine());
      
      string Entrada;
      string []Valores;
      int [,] Matriz;
      Matriz = new int [TamañoN,TamañoN];
      
      for(int i = 0 ; i < TamañoN ; i++){
          Entrada = Console.ReadLine();
          Valores = Entrada.Split(' ');
          for (int j=0; j < TamañoN; j++){
              Matriz[i,j]=Convert.ToInt32(Valores[j]);
          }
      }
    Objeto.TotalReglones = TamañoN;
    Objeto.TotalColumnas = TamañoN;
    Objeto.Arreglo = Matriz;
    Console.WriteLine(Objeto.AnalizarDiagonales());
  }
}