using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1, num2;
            Console.Write("escreva o número aqui: ");
             num1 = int.Parse(Console.ReadLine());
              Console.Write("escreva outro número aqui: ");
             num2 = int.Parse(Console.ReadLine());
           
            if(num1<num2){
                Console.WriteLine(num2);
            } else{
                Console.WriteLine(num1);
            }
        }
    }
}
