using System;

namespace aula3_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Elabore um algoritmo que apresente os//
            // números inteiros de 1 a 100 elevados ao cubo (x³). //
            int cont = 1;
            float s = 0;
            while (cont <= 100)
            {
                s = cont * cont * cont;
                Console.WriteLine(s);
                cont++;
            }

        }
    }
}
