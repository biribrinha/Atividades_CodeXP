using System;

namespace aula4_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia os valores de 10 posições e exiba o vetor e sua última//
            //posição multiplicada por 5.//

            // exiba o vetor= mostrar todos os valores do vetor na tela.//
            //última posição= último numero.//

            int[] valorzinho = new int[10];
            //int volta=0 significa que ele vai começar a contar do 0 //
            // volta <=9 significica o lugar que ele vai parar de contar//
            // ou seja, conta do 0 até o 9 //
            // VETOR SEMPRE CONTA DO 0//
            // ou seja, 10 coisas//
            //valorzinho é o nome da varável;//

            for (int volta = 0; volta <= 9; volta++)
            {
                Console.WriteLine("coloque um numero aqui ow: ");
                valorzinho[volta] = int.Parse(Console.ReadLine());
                //volta é a posição dele ( tudo que é em [] indica posição de vetores//
            }
            for (int volta = 0; volta <= 9; volta++)
            {

                Console.WriteLine( valorzinho[volta]);
            }

            Console.WriteLine( valorzinho[9] * 5);





        }
    }
}
