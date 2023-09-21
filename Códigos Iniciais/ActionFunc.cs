using System;

class ActionFunc {
  static void Main(string [] args) {
    
    //Função sem retorno
    Action apresentaConsole = () => {
        
        Console.WriteLine("Funções e Métodos");
    };
    
    apresentaConsole(); //como não tem retorno é necessário chamar a função
    
    
    //função com retorno
    Func<int> sorteio = () => {
        
        Random random = new Random(); //Random retorna um inteiro aleatorio
        return random.Next(1, 101);

    };
    
    Console.WriteLine(sorteio());
  }
}

// () => {
- arrow: aqui fica o corpo da função
}; 
