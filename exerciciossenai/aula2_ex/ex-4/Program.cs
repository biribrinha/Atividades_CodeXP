using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
           int valor;
           Console.Write("coloque o valor aqui: ");
           valor = int.Parse(Console.ReadLine());
           
            if(valor >= 100 ){
                valor=valor - (valor * 15)/100; 
           }
           Console.WriteLine(valor);
        }
    }
}
