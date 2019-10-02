using System;
using ex2.Controllers;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularControllers Celulinho = new CelularControllers();
            Celulinho.Teste();
             Celulinho.FazerLigacao();
             Celulinho.MandarZap();
             Celulinho.CadastroCelular();

            


        }
    }
}
