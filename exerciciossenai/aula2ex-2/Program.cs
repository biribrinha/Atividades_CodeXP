using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int grana;
        Console.Write("escreva o valor aqui:");
        grana = int.Parse(Console.ReadLine());

        if(grana<100){
            grana=grana - 25;
        }
         
         Console.WriteLine(grana);
        
        
        
                }
    }
}
