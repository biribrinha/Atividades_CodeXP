using System;

namespace _2ex
{
    class Program
    {
        static void Main(string[] args)
        {
         int peso, planeta;
         float pesoplaneta=0;

         Console.WriteLine("coloque seu peso na terra: ");
         peso = int.Parse(Console.ReadLine());
         Console.WriteLine("coloque número do planeta: ");
         planeta = int.Parse(Console.ReadLine());

                switch(planeta){
                 case 1: 
                pesoplaneta= (peso/10)*0.37f;
                break;
                 case 2: 
                pesoplaneta= (peso/10)*0.88f;
                break;
                 case 3: 
                pesoplaneta= (peso/10)*0.38f;
                break;
                 case 4: 
                pesoplaneta= (peso/10)*2.64f;
                break;
                 case 5: 
                pesoplaneta= (peso/10)*1.15f;
                break;
                 case 6: 
                pesoplaneta= (peso/10)*1.17f;
                break;
         }
              Console.WriteLine(pesoplaneta);
        }
    }
}
