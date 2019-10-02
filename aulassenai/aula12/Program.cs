using System;
using aula12.Controllers;

namespace aula12
{
    class Program
    {
        public static object CarroEletrico { get; private set; }

        static void Main(string[] args)
        {
            CarroControllers carro = new CarroControllers();
            CarroControllers CarroEletrico = new CarroControllers();

            Console.Clear(); // limpar a tela do terminal

             CarroEletrico.Ligar();

             CarroEletrico.CarregadorBateria(100);
              CarroEletrico.CarregadorBateria(15);
              System.Console.WriteLine("carga do carro");



        }
    }
}
