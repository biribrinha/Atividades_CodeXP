using System;

namespace aula8_1
{
    class Program
    {
        static void Main(string[] args)
        {
           //TRATRAMENTO DE ERROS
           //try/ cactch

           int numero;


            try{
                //escrevemos um bloco de código
                        Console.WriteLine("digite um numero: ");
           numero = int.Parse(Console.ReadLine());
            }catch(Exception ex){
                //mostramos a exceção da regra
                // erro gerado na aplicação
                Console.WriteLine(" DEU RUIM ;-;. Erro: " + ex);
            }
        
        }
    }
}
