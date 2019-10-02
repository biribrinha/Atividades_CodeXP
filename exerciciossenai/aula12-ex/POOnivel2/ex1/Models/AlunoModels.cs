namespace ex1.Models
{
    public class AlunoModels
    {
        /*1. Criar um programa que leia um aluno. 
        Crie uma classe aluno com as seguintes
        propriedades: Nome, Curso, Idade, RG, Bolsista (boolean). */

        public string Nome { get; set; } //nome do aluno//
        public string Curso { get; set; }   //curso do aluno//
        public int Idade { get; set; }   //idade do aluno//
        public string Rg {get; set;} //rg do aluno//
        public bool Bolsa {get; set;} // se o aluno é bolsista ou não (true or false)


    }
}