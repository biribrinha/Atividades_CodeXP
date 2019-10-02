using System;
using System.Collections.Generic;
using aula13_POOlistas.Models;

namespace aula13_POOlistas
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos nossa classe com o método
            //construtor passando os parametros
            ProdutosModel produtos = new ProdutosModel(1, "maçã", "verde", 3.5);
            //chamamos um atributo do objeto instanciado
            System.Console.WriteLine(produtos.NomeProduto);

            //instanciamos nossa classe
            //sem passar parametros utilizando sobrecarga
            ProdutosModel produto_sobrecarga = new ProdutosModel();
            produto_sobrecarga.IdProduto = 1;
            produto_sobrecarga.NomeProduto = "melão";
            produto_sobrecarga.Descricao = "amarelo";
            produto_sobrecarga.Preco = 5.50;

            //chamamos a nossa lista que vai se
            // do objeto ProdutosModel
            List<ProdutosModel> prod = new List<ProdutosModel>();

            prod.Add(new ProdutosModel(1, "abacate", "tomilho", 2.30));
            prod.Add(new ProdutosModel(2, "Melão", "Maçã", 2.30));
            prod.Add(new ProdutosModel(3, "Pastel", "Caldo de cana", 2.30));
            prod.Add(new ProdutosModel(4, "Morango", "Laranja", 2.30));
            prod.Add(new ProdutosModel(5, "Tomate", "Abacaxi", 2.30));
            prod.Add(new ProdutosModel(6, "Chuchu", "mandioquinha", 2.30));

            //lemos os dados da nossa lista

            foreach (ProdutosModel p in prod)
            {

                System.Console.WriteLine();
                System.Console.WriteLine(p.IdProduto);
                System.Console.WriteLine(p.NomeProduto);
                System.Console.WriteLine(p.Descricao);
                System.Console.WriteLine(p.Preco);
                System.Console.WriteLine();

            }

            //chamamos através do indice do 
            System.Console.WriteLine(prod[4].NomeProduto);


        }
    }
}
