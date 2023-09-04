﻿using System;

class Conclusao { //classe mãe
    static void Main(){

        float media = 0;

        Console.WriteLine ("Olá, bem vindo ao programa de cálculo de média!");
        Console.WriteLine ("Irei auxiliar você a calcular a média do seu aluno!");

        Console.WriteLine ("Digite a primeira nota: ");
        int.TryParse(Console.ReadLine(), out int nota1); //passa string para int

        Console.WriteLine ("Digite a segunda nota: ");
        int.TryParse(Console.ReadLine(), out int nota2); //passa string para int

        media = (nota1 + nota2)/2; //calcula média

        Console.WriteLine ($"A media do aluno é: {media}");

        if (media < 8){

            Console.WriteLine ("O aluno está de recuperação!");
            Console.ReadKey();

        }else{

            Console.WriteLine ("O aluno passou na matéria!");
            Console.ReadKey();
        }


    }
}