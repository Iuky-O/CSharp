using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Fucionalidades.Calculadora
{
    public class operacao
    {

     public int soma(int num1, int num2){

        return num1 + num2;
     }   

     public int subtracao (int num1, int num2){

        return num1 - num2;

     }

     public double divisao (double num1, double num2){

        return num1/num2;
     
     }

     public double multiplicacao (double num1, double num2){

        return num1*num2;

     }


    }
}