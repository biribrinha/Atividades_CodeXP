using System;

namespace Senai.POO.Aluno.Models
{
    public class AlunoModel
    {
        class program
        {
            public static string Aluno { get; private set; }

            static void main (string[] args){
                
                //declarando objeto
                AlunoModel aluno = new AlunoModel(); // especificar o objeto
                System.Console.WriteLine("insira seu nome: ");
                Aluno = Console.ReadLine();
                
            }
        }

           
       }
    }
