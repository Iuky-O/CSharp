//está dando erro
//aula de Get e Set
using System;

class GetSet {
    
    public class Carro{
        
        private string Marca;
        private string Nome;
        private double Potencia;
    }
    
    public Carro (string marca, string nome, double potencia){
        
        Marca = marca;
        Nome = nome;
        Potencia = potencia;
    }
    
    public Carro(){
        
    }
    
    //para visualizar o atributo privado
    public GetMarca(){
        
        return Marca;
    }
    
    //para alterar o atributo privado
    public SetMarca(string marca){
        
        Marca = marca;
    }
    
    //para visualizar o atributo privado
    public GetNome(){
        
        return Nome;
    }
    
    //para alterar o atributo privado
    public SetNome(string nome){
        
        Nome = nome;
    }
    
    //para visualizar o atributo privado
    public GetPotencia(){
        
        return Potencia;
    }
    
    //para alterar o atributo privado
    public SetPotencia(double potencia){
        
        Potencia = potencia;
    }
    
}
