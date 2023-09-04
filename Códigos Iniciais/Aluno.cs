using System;

class Aluno {
    
    //atributos públicos - visiveis para todos
    public string Nome;
    public int Idade;
    public int Serie;
    
    public string Retorno (){
        
        return string.Format ($" O aluno {Nome} tem {Idade} anos e pertence ao {Serie} ano.");
    }
    
    public void RetornoConsole (){
        
        Console.WriteLine(Retorno());
    }

  }
  
class Programa {
    
    static void Main (string[] args){

        var aluno1 = new Aluno(); //na classe aluno é incluido o objeto aluno1 como novo aluno

        aluno1.Nome = "João";
        aluno1.Idade = 13;
        aluno1.Serie = 6;
        
        aluno1. RetornoConsole ();
        
        //Console.WriteLine ($" O aluno {aluno1.Nome} tem {aluno1.Idade} anos e pertence ao {aluno1.Serie} ano.");
        
    }
    
}