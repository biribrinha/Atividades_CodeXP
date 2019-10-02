using System;
using aula12_ex.models;

namespace aula12_ex.Controllers
{
    public class PessoaControllers
    {
        //segunda pasta a ser usada//

        /*importar o model pro controller
        que seria
        usar as coisas do model no controler
        controllers pegou emprestado os objetos(variaveis)
         do models :) então como ainda é do models,
          tem que ligar ele ao controller */

        PessoaModels pessoa = new PessoaModels();


        //criando uma função = criar uma caixa pra guardar as informações
        public void CadastroPessoa()
        {

            System.Console.WriteLine("escreva seu nome aqui senhor pessoa: ");
            pessoa.Nome = Console.ReadLine();

            System.Console.WriteLine("me diz aí, qual a sua idade? ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("então, perguntinha chata, mas me fala teu peso: ");
            pessoa.Peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("eai, qual tua altura: ");
            pessoa.Altura = double.Parse(Console.ReadLine());

            //agora tenho que exibir na tela o resultado criando outra função
            // lembra que é depois da chave né - manu
        }
        //função para exibir os resultados
        public void ImprimePessoa()
        {

            System.Console.WriteLine(pessoa.Nome);
            System.Console.WriteLine(pessoa.Idade);
            System.Console.WriteLine(pessoa.Peso);
            System.Console.WriteLine(pessoa.Altura);

            // System.Console.WriteLine($"seu IMC é: ");

        }
        //criando uma função para o calculo do maltido IMC :)
        /*calcular o Índice de Massa Corporal (IMC). 
            O cálculo é feito através
            da fórmula IMC = peso/altura² */

        public void ImcPessoa()
        {
            double ImcPessoa;
            ImcPessoa = pessoa.Peso / (pessoa.Altura * pessoa.Altura);

            //usando o if pra definir se o peso tá ok ou não

            if (ImcPessoa <= 18.5)
            {
                System.Console.WriteLine("Ce ta abaixo do peso :(, melhor cuidar da saúde....");
            }
            else if (ImcPessoa >= 18.5 || ImcPessoa <= 25)
            {
                System.Console.WriteLine("Seu peso tá normal, sempre mantenha uma rotina saudável :)");
            }
            else if (ImcPessoa >= 26 || ImcPessoa <= 30)
            {
                System.Console.WriteLine("ce ta com sobrepeso! preste mais atenção na sua rotina...");
            }
            else if (ImcPessoa >= 31 || ImcPessoa <= 35)
            {
                System.Console.WriteLine("Obesidade grau I!!!!!!!!!!!!");
            }
            else if (ImcPessoa >= 36 || ImcPessoa <= 39)
            {
                System.Console.WriteLine("Obesidade grau II!!!!!!!!!!!!!!!!");
            }
            else
            {
                System.Console.WriteLine("Obesidade grau III........");
            }
        }

    }
}