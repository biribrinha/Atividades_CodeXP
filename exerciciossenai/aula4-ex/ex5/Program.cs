using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
           /*5) Faça um algoritmo que gere um vetor 
           de 10 posições sendo que seu conteúdo seja o
            dobro de seu próprio índice. */
            // índice é o lugarzinho no número

            int[] numerozinho = new int[10];
            for (int volta = 0; volta < 9; volta++){
                 Console.WriteLine("coloque um número aqui: ");
                numerozinho[volta] = int.Parse(Console.ReadLine());
                }
                for (int volta = 0; volta < 9; volta++){
                    Console.WriteLine(numerozinho[volta] * 2);
                }
           
        }
    }
}
