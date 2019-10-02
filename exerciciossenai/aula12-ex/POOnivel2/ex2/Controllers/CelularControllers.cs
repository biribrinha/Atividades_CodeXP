using System;
using ex2.Models;

namespace ex2.Controllers
{
    public class CelularControllers
    {
        CelularModels Celular = new CelularModels();
        string Resposta;
        string Resposta2;

    
        public void Teste(){
            System.Console.WriteLine("deseja ligar o celular?(sim/não)");
            Resposta= Console.ReadLine();
            
    
            if (Resposta == "sim")
            {

               Celular.Ligado = true;
                System.Console.WriteLine("Ligando o celulinho");
            }
            else
            {
                Celular.Ligado = false;
                System.Console.WriteLine("impossível fazer os outros comandos");
            }
        }
        
    
        public void FazerLigacao(){
            System.Console.WriteLine("deseja fazer uma ligação?(sim/não)");
            Resposta2= Console.ReadLine();
            if (Resposta2 == "sim" && Celular.Ligado== true)
            {
                System.Console.WriteLine("fazendo a ligação... * vc tem créditos, né?");
            }
            else if(Resposta2== "não"){
                System.Console.WriteLine("ok....");
            } if (Celular.Ligado == false)
            {
                System.Console.WriteLine("impossível fazer os outros comandos");
            }
        }

        public void MandarZap()
        {
             System.Console.WriteLine("Deseja mandar um zap? (sim/não)");
                Resposta= Console.ReadLine();
            if (Resposta2 == "sim" && Celular.Ligado== true)
            {
                System.Console.WriteLine("Mandando um zap pra webnamorada..");
            }
           else if(Resposta2== "não"){
                System.Console.WriteLine("sua webnamorada não vai gostar de saber isso...");
            } if (Celular.Ligado == false)
            {
                System.Console.WriteLine("impossível fazer os outros comandos");
            }
        }
        public void CadastroCelular()
        {
            System.Console.WriteLine("conta aí, qual é a cor do celular? ");
            Celular.Cor = Console.ReadLine();
            System.Console.WriteLine("qual o modelo do teu celular?  ");
            Celular.Modelo = Console.ReadLine();
            System.Console.WriteLine("E aí, qual o tamanho? (pequeno/médio/grande) ");
            Celular.Tamanho = Console.ReadLine();
        }
    }
}
