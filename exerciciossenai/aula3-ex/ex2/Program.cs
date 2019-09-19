using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2)Elabore um algoritmo que mostre o resultado
            da tabuada de um número inteiro dado
            pelo usuário. O formato deve ser apresentado na forma:
            Exemplo, para o número 2
            2 X 1 = 2
            2 X 2 = 4
            (...)
            2 X 10 = 20 */


            int tabuada, num= 1, mult;
            // o num foi colocado pra representar a variável contadora//
            // uma variável pro numero que o usuário vai colocar (tabuada)
            // outra variável pra pegar oq o usuário digitou e multiplicar pelo giro 
            
                Console.WriteLine("coloque o número aqui: ");
                tabuada= int.Parse(Console.ReadLine());
                  

            // o while vai girar até chegra no décimo giro
                while(num<=10){
                        mult= tabuada * num;
                        Console.WriteLine($"{tabuada} X {num}= {mult}");
                        //NÃOESQUECER DE COLLOCAR ISSO POR FAVOR
                        // SE NÃO DÁ LOOP INFINITO
                        // MAS CASO DE, USAR O CTRL C PRA PARAR!
                        num ++;
                }
                
             
        


        }
    }
}
