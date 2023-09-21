using System;
using System.Linq; //importa a biblioteca para LINQ

namespace LINQ {
    
    class Program {
        
        static void Main (string[] args){
            
            int[] numeros = new int[]{1, 2, 3, 4, 5, 6, 7, 8}; //fonte de dados
            
            var operacao = numeros.Where(x => x % 2 == 0); 
            // a varavel operacao recebe o objeto numeros com a base de dados, ONDE numeros(x%2 == 0)
            
            foreach (int x in operacao){ //percorre int x EM operacao
                
                Console.WriteLine(x);
            }
        }
    }
}
