using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // somente declaramos, sem atribuir valor//
            int num1;
            //declaramos atribuindo um valor//
            int num2 =5;
        // declaramos diversas variaveis de mesmo tipo//
            int num3, num4, num5 = 7;
            //variavel do tipo decimal (real)//
            float media;
        // variável do tipo lógico (booleana)//
            bool resultado = false;
            // variável do tipo texto (carateres)//
            string nomeAluno;

            //quebra a linhas//
            Console.WriteLine();

        //escreve em uma linha quebrando-a//
            Console.WriteLine("Bem vindos a nossa primeira aplicação");

            //continua escrevendo na mesma linha//
            Console.Write("digite");
            Console.Write(" seu nome:");

        // capturo o dado digitando pelo usuário e salvo na variável//
                    nomeAluno = Console.ReadLine();

        // concatenação //
            Console.WriteLine(nomeAluno  +  ", agora digite sua primeira nota:");

        // converto o texto capturado//
            num3 = int.Parse(  Console.ReadLine()  );

        // interpolação//
        Console.WriteLine($"Sua primeira nota é{ num3 }");

        Console.WriteLine("digite sua segunda nota");
        num4 = int.Parse( Console.ReadLine()  );

        Console.WriteLine("digite sua terceira nota");
        num5 = int.Parse( Console.ReadLine()  );

        media = ( num3 + num4 + num5) / 3; 
        Console.WriteLine("sua média é:" + media);








        }
    }
}
