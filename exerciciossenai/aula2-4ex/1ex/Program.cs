using System;

namespace _1ex
{
    class Program
    {
        static void Main(string[] args)
        {
        int pedido;
        string caracteres;
          Console.WriteLine("digite o número do pedido: ");
          pedido = int.Parse(Console.ReadLine());

          switch(pedido){
            case 1:
                caracteres = "hamburguer";
            break;
                         
                         
            case 2:
                caracteres = "cheese salada";
            break;

                         
                         
            case 3:
                caracteres = "cheese burguer";
            break;

            case 4:
                caracteres = "cheese bacon";
            break;
            default:
                caracteres = "opção inválida";
            break;
                         
            }
            Console.WriteLine(caracteres);
        }
    }
}