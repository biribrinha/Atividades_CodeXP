using System;
using aula12.Models;

namespace aula12.Controllers
{
    public class CarroControllers
    {
        CarroModels carro = new CarroModels();
        MotorModels motor = new MotorModels();

        public void ligar()
        {
            carro.Ligado = true;
            System.Console.WriteLine("ligando o carro!!!!!!!!!");
        }

        public void desligar()
        {
            carro.Ligado = false;
            System.Console.WriteLine("desligando o carro :(((( ...............");
        }

        internal void Ligar()
        {
            throw new NotImplementedException();
        }

        internal void CarregadorBateria(int v)
        {
            throw new NotImplementedException();
        }

        public void Acelerar()
        {
            if (carro.Ligado == true)
            {
                System.Console.WriteLine("carro acelerando :O");
            }
            else
            {
                System.Console.WriteLine("o carro não está ligado :/.... Impossível acelerar, gênio!");
            }

        }
        
            public void Frear()
            {
                if (carro.Ligado ==true)
                {
                    System.Console.WriteLine("Caro freando .......................");
                }else
                {
                    System.Console.WriteLine("Carro desligado, impossível frear!");
                }
            }

            public void CadastrarMotor()
            {
                System.Console.WriteLine("insira quantos cavalos tem o motor: ");
                motor.Cavalos = int.Parse(Console.ReadLine());

                System.Console.WriteLine("insira quantos cilindros tem o carro: ");
               motor.Cilindros = int.Parse(Console.ReadLine());

                System.Console.WriteLine("insira o modelo do pistão do carro: ");
              motor.Pistao = int.Parse(Console.ReadLine());

                        
                
            }
    }
}