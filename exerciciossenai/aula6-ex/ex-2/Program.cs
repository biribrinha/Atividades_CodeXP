using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Criar uma função do tipo double que
            //recebe como argumentos valor e
            //porcentagem, onde o intuito é atribuir um
            // desconto sobre a porcentagem e retornar
            //o valor aplicado o desconto

            //atribuir ==
                 
            Console.WriteLine("digite um valor:  ");
            double valor = double.Parse(Console.ReadLine());
             Console.WriteLine("digite um desconto:  ");
            double desconto = double.Parse(Console.ReadLine());
             Console.WriteLine(Valor(valor, desconto));
        }
        static double Valor(double valor, double desconto)
        {
            double resultado=0;
            resultado= valor - (valor * desconto/100);
            return resultado;
             
                
        }
          
        
        
    }
}
