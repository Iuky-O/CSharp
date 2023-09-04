using System;

class ParametroReferencia {
    
    //aceita parametro por referencia - ref
    public static void AlterarRef(ref int numero){
        
        numero = numero + 500;
    }
    
    //não eceita parametro por referencia
    public static void AlterarOut (int numero){
        
        numero = numero + 50;
    }
    
    public static void Main(){
        
        int x = 5;
        AlterarRef (ref x); //passa x por referencia
        Console.WriteLine (x);
        
        int y = 8;
        AlterarOut (y);
        Console.WriteLine (y);
    }
   
}