using System;

namespace ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
        Console.Write("digite sua idade aqui: ");
         idade = int.Parse(Console.ReadLine());

         if(idade>=18){
             Console.WriteLine("adults only");
         }
         if(idade<=17){
             Console.WriteLine("mature +17");
         }
         if(idade<=13){
             Console.WriteLine("teen");
         }
         if(idade<=10){
             Console.WriteLine("everyone +10");
         }
         else{
             Console.WriteLine("everyone");
         }
        }
    }
}
