using System;

namespace Delegate{
    
    delegate double BinaryNumericOperation (double n1, double n2);
    
    class Program{
        
        class Calculadora {
            
            public static double Max (double x, double y){
                
                if (x > y){
                    
                    return x;
                    
                } else {
                    
                    return y;
                }
            }
            
            public static double Soma (double x, double y){
                
                return x + y;
                
            }
            
        }
        
        static void Main(string [] args) {
            
            Console.WriteLine("Insira o valor: ");
            double.TryParse(Console.ReadLine(), out double a);
            
            Console.WriteLine("Insira o segundo valor: ");
            double.TryParse(Console.ReadLine(), out double b);
            
            //double a = 10;
            //double b = 30;
            
            BinaryNumericOperation operacao = Calculadora.Soma; //operação recebe a classe calculadora e o metodo soma
            
            Console.WriteLine("\n{0}", operacao(a, b)); //envia as variaveis
            //Console.WriteLine(operacao(a,b));
   
        }
    }
}

