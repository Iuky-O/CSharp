
using System;

//classe mãe
public class Mensagem {
    
    private string texto; //atributo privado/proprio da classe
    
    //método para exibir
    public void Exibir (){
        
        Console.WriteLine ($"\nVocê digitou: {this.texto}");
    }
    
    //get: para acessar o conteudo texto
    public string getTexto (){
        
        return this.texto;
    }
    
    //para modificar o conteudo
    public void setTexto (string txt){
        
        this.texto = txt;
    }
    
    
    static void Main (string [] args){
        
        Mensagem txt1;
        
        txt1 = new Mensagem (); //novo objeto na classe Mensagem
        
        Console.WriteLine("Digite algo: ");
        string txt2 = Console.ReadLine();
        txt1.setTexto (txt2); //chama o metodod set e envia
        
        txt1.Exibir(); //chama o metodo para exibição
    }
} 