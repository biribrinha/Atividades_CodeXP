using System;

namespace aula2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //deixamos declarada como falsa por padrão//
            bool entrada = false;
            int idade;

            Console.Write("digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            string retorno = "Entrada não permitida.";

            // como já atribuimos anteriormente, mudamos o estado da variável 
            //para verdadeira caso entre nessa condição //
            if (idade > 17)
            {
                entrada = true;
            }

            if (entrada == true)
            {
                retorno = "entrada permitida!!!!!!!!!!!!!";
            }
            else
            {
                retorno = "entrada não permitida... :c ";
            }

            Console.WriteLine(retorno);




        }
    }
}
