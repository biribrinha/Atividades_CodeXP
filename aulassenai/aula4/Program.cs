using System;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] media = new double[10];

            // o laço tem que começar do 0 pq variável 
            //funciona assim
            for (int i = 0; i <= 9; i++)
            {

                Console.Write("digite uma media: ");
                media[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(media[3]);
            Console.WriteLine();
                /// o lenght pega a quantidade de vetores 
            ///   que eu tenho (caso eu não soubesse a quantidade)
            for(int i=0; i <= media.Length -1 ; i ++){

                Console.WriteLine("media : "+ media[i] );
            }
        }
    }
}
