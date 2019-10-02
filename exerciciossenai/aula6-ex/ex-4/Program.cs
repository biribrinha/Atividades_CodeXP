using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar uma sobrecarga de métodos chamada MostraInfo onde:
            //a) 1 - Sem argumentos, escreve no console a razão 
            //social da escola Senai de Informática
            //b) 2 - Com dois argumentos, retorna seu nome é sobrenome
            //c) 3 - Com três argumentos, retorna sua idade, peso e altura

            //argumentos são os que vão dentro dos parenteses, variáveis

            MostraInfo();
            System.Console.WriteLine("Escreva seu nominho aqui: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Escreva seu sobrenomeee aqui: ");
            string sobrenome = Console.ReadLine();

            System.Console.WriteLine(MostraInfo(nome, sobrenome));

            System.Console.WriteLine("Escreva sua idade aqui: ");
            string idade = (Console.ReadLine());
            System.Console.WriteLine("Escreva seu peso aqui: ");
            string peso = (Console.ReadLine());
            System.Console.WriteLine("Escreva sua altura aqui: ");
            string altura = (Console.ReadLine());

            System.Console.WriteLine(MostraInfo(idade, peso, altura));




        }

        //VOID VAZIO VAZIOOOOOOOOOOOOOOOOOOO
        //primeira sobrecarga
        static void MostraInfo()
        {
            System.Console.WriteLine("Razão social: Servico Nacional de Aprendizagem Industrial");
        }
        //segunda sobrecarga

        static string MostraInfo(string nome, string sobrenome)
        {
            return nome + sobrenome;
        }

        //terceira sobrecarga

        static string MostraInfo(string idade, string peso, string altura)
        {
            return (idade + peso + altura);
        }
    }
}

