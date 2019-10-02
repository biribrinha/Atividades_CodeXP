using System;
using ex1.Controllers;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
             AlunoControllers Aluno = new AlunoControllers();

             Aluno.CadastroAluno();
             Aluno. ImprimeAluno();
             

        }
    }
}
