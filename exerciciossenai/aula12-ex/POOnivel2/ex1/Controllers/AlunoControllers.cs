using System;
using ex1.Models;

namespace ex1.Controllers
{
    public class AlunoControllers
    {
        AlunoModels Aluno = new AlunoModels();

        string Resposta;

        public void CadastroAluno()
        {

            System.Console.WriteLine("escreva seu nome aqui querido aluno: ");
            Aluno.Nome = Console.ReadLine();

            System.Console.WriteLine("de qual curso voce é? ");
            Aluno.Curso = Console.ReadLine();

            System.Console.WriteLine("qual a sua idade?  ");
            Aluno.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("por favor, digite o seu rg: ");
            Aluno.Rg = (Console.ReadLine());

            System.Console.WriteLine("ce tem bolsa? (sim/ não) ");
            Resposta = Console.ReadLine();


            if (Resposta == "sim")
            {

                Aluno.Bolsa = true;
                System.Console.WriteLine("bolsista");
            }
            else
            {
                Aluno.Bolsa = false;
                System.Console.WriteLine("mensalidade comum");
            }


        }
        public void ImprimeAluno (){

            System.Console.WriteLine(Aluno.Nome);
            System.Console.WriteLine(Aluno.Curso);
            System.Console.WriteLine(Aluno.Idade);
            System.Console.WriteLine(Aluno.Rg);
            System.Console.WriteLine(Aluno.Curso);

        }

    }

}