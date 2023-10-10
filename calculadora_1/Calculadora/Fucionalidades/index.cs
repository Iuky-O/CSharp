using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System;

using Fucionalidades.Calculadora;

public class Menu{

    public static void Main(){
        int valor1, valor2;
        int decisao = 0;


        Console.WriteLine("Digite o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());

        operacao opr = new operacao();

        while(decisao != 5){

            Console.WriteLine("O que deseja executar?");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - DIVISÃO");
            Console.WriteLine("4 - MULTIPLICAÇÃO");
            Console.WriteLine("5 - FINALIZAR PROGRAMA");
            Console.Write(" --> ");
            decisao = int.Parse(Console.ReadLine());

            switch (decisao){
                case 1:
                    Console.WriteLine(opr.soma(valor1, valor2));
                    break;
                case 2:
                    Console.WriteLine(opr.subtracao(valor1, valor2));
                    break;
                case 3:
                    Console.WriteLine(opr.divisao(valor1, valor2));
                    break;
                case 4:
                    Console.WriteLine(opr.multiplicacao(valor1, valor2));
                    break;
                case 5:
                    Console.WriteLine("PROGRAMA FINALIZADO!");
                break;
                default:
                    Console.WriteLine("Valor invalido!");
                break;


            }


        }
        

    }
}