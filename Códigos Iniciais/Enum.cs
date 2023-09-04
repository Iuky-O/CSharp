using System;

class Enum {
    //Enum: Variavel sem tipo claro e comum - enumerndo os valores do enum
    public enum Genero {Filme, Serie, Documentario};
    
    public class Filme{
        
        public string Nome;
        public Genero TipoVideo;
        
    } 
    
  static void Main() {
      
      int cod = (int)Genero.Serie;
      Console.WriteLine(cod);
 
  }
}