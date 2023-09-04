namespace media;

public class soma{

    static void Main(){
        bool opc = true; //controle do while

        Console.WriteLine ("Ola, irei realizar a soma de numeros que você desejar parar");


        Console.WriteLine ("Digite o valor inicial: ");
        float.TryParse(Console.ReadLine(), out float inicial);

        //vai verificar se opc continua valida e continuar
        while(opc == true){

            Console.WriteLine($"Qual numero deseja somar com {inicial}? ");
            float.TryParse(Console.ReadLine(), out float valor);

            inicial = inicial + valor; //é feita a soma em inicial

            Console.WriteLine($"a soma até o momento é: {inicial}");

            Console.WriteLine ("Deseja continuar a soma? 1 - SIM , 2- NÃO");
            int.TryParse(Console.ReadLine(), out int saida);

            switch (saida){

                case 1:
                Console.WriteLine ("Constinuar a soma!");
                break;

                case 2:
                Console.WriteLine ("Programa finalizado!");
                opc = false;
                Console.ReadKey();
                break;

                default:
                    Console.WriteLine ("OPÇÃO INVALIDA!!");
                    Console.WriteLine ("Continuando a soma...");

                    break;
                
            }
        }
        
    }

}
