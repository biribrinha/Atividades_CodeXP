using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Faça um algoritmo que leia os valores de dois 
            //vetores de 10 posições gere um terceiro
            //vetor de 20 posições que seja a união dos dois primeiros.

            int[] valorzinho = new int[10];
            int[] valorzao = new int[10];
            int[] valores = new int[20];

            for (int posicao = 0; posicao <= 9; posicao++)
            {
                Console.WriteLine("coloque um numerozinho aqui: ");
                valorzinho[posicao] = int.Parse(Console.ReadLine());
            }
            for (int posicao = 0; posicao <= 9; posicao++)
            {
                Console.WriteLine("coloque um numerozinho aqui: ");
                valorzao[posicao] = int.Parse(Console.ReadLine());
            }
            for (int posicao = 0; posicao <= 9; posicao++)
            {
                Console.WriteLine(valores[posicao] = valorzinho[posicao]);
                Console.WriteLine(valores[posicao] = valorzao[posicao]);
            }

        }
    }
}
