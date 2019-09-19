using System;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("escreva um número aqui: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("escreva outro número aqui: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("escreva outro número aqui: ");
            num3 = int.Parse(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine(num1);

            }
            else if ((num2 >num1) && (num2 > num3))
            {
                Console.WriteLine(num2);
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                Console.WriteLine(num3);
            }




        }
    }
}
