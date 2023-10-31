

class Matriz {
  static void Main() {
      
      OperacionMatriz Objeto = new OperacionMatriz();
      int TamañoF,TamañoC;
    
      string Entrada;
      string []Valores;
      int [,] Matriz;
     int [,] MatrizInvertida;
         Entrada = Console.ReadLine();
         Valores = Entrada.Split(' ');
         TamañoF.Convert.ToInt32(Valores[0]);
         TamañoC.Convert.ToInt32(Valores[1]);
      Matriz = new int [TamañoF,TamañoC];
      
      for(int i = 0 ; i < TamañoF ; i++){
          Entrada = Console.ReadLine();
          Valores = Entrada.Split(' ');
          for (int j=0; j < TamañoC; j++){
              Matriz[i,j]=Convert.ToInt32(Valores[j]);
          }
      }
    Objeto.TotalReglones = TamañoF;
    Objeto.TotalColumnas = TamañoC;
    Objeto.Arreglo = Matriz;
    
    MatrizInvertida= Objeto.InvertirArreglo();
    
    //Console.WriteLine(Objeto.InvertirArreglo());
  }
}