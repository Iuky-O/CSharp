
using System;

public class Professor {
    
    protected readonly float salarioMaximo; //não pode ser modificado
    float salarioatual; //atualiza o slario do Professor
    
    //método construtor para o salario maximo
    public Professor (float salarioMax){
        
        salarioMaximo = salarioMax;
    }
    
    //define o limite de salário, com a maxima e a minima
    protected float ModificarSalario (float Modf){
        
        float NovoSalario = salarioatual + Modf;
        
        if (NovoSalario < 0){
            
            salarioatual = 0;
            
        } else if (NovoSalario > salarioMaximo){
            
            salarioatual = salarioMaximo;
            
        } else{
            
            salarioatual = NovoSalario;
        }
        
        return salarioatual;
    }
    
    //aumenta salario 
    public float AumentaSalario (){
        
        return ModificarSalario (+500);
        
    }
    
    //reduz salario
    public float DiminuiSalario (){
        
        return ModificarSalario (-500);
        
    }
    
    
    //a classe prof herda da classe mãe professor
    public class Prof: Professor {
        
        public Prof (): base (1400){
            
        }
        
    }
    
    public static void Main(){
        
        Console.WriteLine ("Professor 1: ");
        Prof prof1 = new Prof (); //instanciando a classe com um novo objeto prof1
        
        //printa o salario... aumentando
        Console.WriteLine (prof1.AumentaSalario());
        Console.WriteLine (prof1.AumentaSalario());
    }

  }

//saida: Professor 1:
//       500
//       1000
