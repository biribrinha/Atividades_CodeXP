using System;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Criar um método do tipo double 
            //onde retorna o maior número de um vetor de
            //tamanho indeterminado.
            double[] num1 = new double[1];
            double[] num2 = new double[1];

            System.Console.WriteLine("escreva um número: ");
            num1[1]=double.Parse(Console.ReadLine());
            
             System.Console.WriteLine("escreva um número2: ");
            num2[1]=double.Parse(Console.ReadLine());
            // Console.WriteLine(Metodo);

        }
          static double Metodo (double num1, double num2){

                  if(num1>num2){
                      Console.WriteLine(num1);
                      return num1;
                  }else{
                      Console.WriteLine(num2);
                      return num2;
                  }

                  //o return só pode ficar fora. Ele é a última coisa que se coloca na função

                  

    }
}
}
