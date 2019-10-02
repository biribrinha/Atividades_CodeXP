using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4) Dados dois vetores, A e B com
             15 palavras, construa um terceiro vetor com os dados
          dos vetores anteriores */

            string[] A = new string[15];
            string[] B = new string[15];
            string[] AB = new string[30];
            // o A.length faz com que não seja necessário colocar a última posição
            //ele mesmo coloca
            for (int volta = 0; volta < A.Length; volta++)
            {
                Console.WriteLine("coloque uma palavra aqui: ");
                A[volta] = (Console.ReadLine());
                Console.WriteLine("coloque uma palavra aqui: ");
                B[volta] = (Console.ReadLine());
            }

            for (int volta = 0; volta < A.Length; volta++)
            {
                Console.WriteLine(AB[volta] = A[volta]);
                Console.WriteLine(AB[volta] = B[volta]);
            }


        }
    }
}
