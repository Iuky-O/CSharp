using System;

class MetodoEstatico {
    
    public static int Somar (int x, int y){
        
        return x + y;
        
    }
    
    public static int Multiplicar (int x, int y){
        
        return x * y;
    }
    
    
    static void Main (string [] args){
        
        //foi criado uma variavel para armazenar a soma - ao chamar o metodo estático somar
        var result = MetodoEstatico.Somar(3, 3);
        Console.WriteLine($" A soma é = {result}");
        
        //aqui a chamada do método foi feita diretamente sem armazenar em uma variável 
        Console.WriteLine($" A multiplicação é = {MetodoEstatico.Multiplicar(2, 10)}");
    }
        
        
}

/*using System;

class MetodoEstatico {
    
    public static int Somar (int x, int y){
        
        return x + y;
        
    }
    
    //agora sem ser um metodo estático:
    public int Multiplicar (int x, int y){
        
        return x * y;
    }
    
    
    static void Main (string [] args){
        
        //foi criado uma variavel para armazenar a soma - ao chamar o metodo estático somar
        var result = MetodoEstatico.Somar(3, 3);
        Console.WriteLine($" A soma é = {result}");
        
        //sem a classe estática é necessário instanciar o objeto - calc e direcionar ao MetodoEstatico
        MetodoEstatico calc = new MetodoEstatico ();
        Console.WriteLine($" A multiplicação é = {calc.Multiplicar(2, 10)}");
    }
        
        
}*/