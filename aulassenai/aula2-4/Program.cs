using System;

namespace aula2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            int final;
            string resultado;

            Console.Write("Digite a placa do seu carro: ");
            placa = Console.ReadLine();

            // contamos a quantidade de caracteres de um elemento//
            int caracteres = placa.Length;

            // pegamos o último digito com o método substring()//

            final = int.Parse(placa.Substring(caracteres - 1));

            if (final == 1 || final == 2)
            {
                resultado = "IF/ELSE - seu rodízio é na segunda-feira!";
            }
            else if (final == 3 || final == 4)
            {
                resultado = "IF/ELSE - seu rodízio é na terça-ferira!";
            }
            else if (final == 5 || final == 6)
            {
                resultado = "IF/ELSE - seu rodízio é na quarta-feira";
            }
            else if (final == 7 || final == 8)
            {
                resultado = "IF/ELSE - seu rodízio é na quinta feira";
            }
            else if (final == 9 || final == 0)
            {
                resultado = "IF/ELSE - seu rodízio é na sexta";
            }
            else
            {
                resultado = "IF/ELSE -  placa inválida! (o°-°o) ";
            }

            Console.WriteLine(resultado);

            switch (final)
            {
                case 1:
                    resultado = "switch - segunda-feira";
                    break;

                case 2:
                    resultado = "switch - segunda-feira";
                    break;

                case 3:
                    resultado = "switch - terça-feira";
                    break;

                case 4:
                    resultado = "switch - terça-feira";
                    break;

                case 5:
                    resultado = "switch - quarta-feira";
                    break;

                case 6:
                    resultado = "switch - quarta-feira";
                    break;

                case 7:
                    resultado = "switch - quinta-feira";
                    break;

                case 8:
                    resultado = "switch - quinta-feira";
                    break;

                default:
                    resultado = "switch - entrada inválida! :c ";
                    break;
            }
            Console.WriteLine(resultado);



        }
    }
}
