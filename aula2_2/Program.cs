using System;

namespace aula2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //definimos as variaveis que utilizaremos para fazer o cálculo//
            float nota1, nota2, nota3, media;
            string resultado;

            Console.Write ("digite a primeira nota:");
            nota1 = float.Parse ( Console.ReadLine());

            
            Console.Write ("digite a segunda nota:");
            nota2 = float.Parse ( Console.ReadLine());

            
            Console.Write ("digite a terceira nota:");
            nota3 = float.Parse ( Console.ReadLine());

            media = (nota1 + nota2 + nota3) /3;
            if(media>=6){
                resultado = "aprovado";
            }else if(media < 6 && media >= 4){

                resultado = "recuperação";
            }else{
                resultado = "reprovado";
            }

            Console.WriteLine($"Média: {media} - Aluno está de {resultado}");
        }
    }
}
