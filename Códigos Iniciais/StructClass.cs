//diferença de struct para class
//struct: a atribuição é sempre feita por valor
//classe: a atribuição é feita por referencia.
using System;

class StructClass {
    
    public struct PontoS{
        
        public int x;
        public int y;
    }
    
    public class PontoC{
        
        public int x;
        public int y;
    }
    
    public static void Main(){
        
        PontoS ponto = new PontoS {x = 5, y =3};
        PontoS ponto2 = ponto; //copiar atraves do valor
        ponto.x = 3; //mudou o ponto x = 5 para x = 3  
        //porem não modifica o ponto2 que recebe os valores do ponto - já que o mesmo será executado primeiro
        
        Console.WriteLine($"Ponto: {ponto.x}");
        Console.WriteLine("Ponto 2: {0}", ponto2.x);
        
        
        PontoC ponto3 = new PontoC {x = 6, y =9};
        PontoC ponto4 = ponto3; //copiar atraves do valor
        ponto3.x = 3; //mudou o ponto x = 6 para x = 3
        //aqui o ponto4 é modificado - pois a atribuição é passada por referencia. R:ponto4.x = 3;
        
        Console.WriteLine($"Ponto 3: {ponto3.x} / Ponto 4: {ponto4.x}");
        Console.ReadKey();
    }
}