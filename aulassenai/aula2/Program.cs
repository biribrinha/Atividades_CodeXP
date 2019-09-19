using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;
            // capturamos a primeira nota//
            Console.Write("digite sua primeira nota:");
            nota1 = double.Parse (Console.ReadLine());

            // capturamos a segunda nota//
             Console.Write("digite sua primeira nota:");
            nota2 = double.Parse (Console.ReadLine());

            // capturamos a terceira nota//
             Console.Write("digite sua primeira nota:");
            nota3 = double.Parse (Console.ReadLine());

            // processamento pra calcular a media//
            media = (nota1+nota2+nota3) /3;

            // verificamos se a media do aluno é maior ou igual a 6 //
            if (media >=6) {
                Console.WriteLine($"Média: {media} aluno aprovado");
            }   else{

                Console.WriteLine($"Média: {media}aluno reprovado");
            }



        }
    }
}
