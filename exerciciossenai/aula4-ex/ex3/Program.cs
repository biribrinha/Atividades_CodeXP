using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3) Um site na web precisa registrar 12 
            produtos de um fornecedor, crie um vetor para
            representar estes produtos com os seguintes 
            atributos: Nome do produto, Cor,
            Tamanho e Preço.*/

            string[] nomeproduto = new string[12];
            string[] corproduto = new string[12];
            string[] tamanhoproduto = new string[12];
            double[] precoproduto = new double[12];

            for (int volta = 0; volta <= 11; volta++)
            {
                Console.WriteLine("coloque o nome do produto aqui: ");
                nomeproduto[volta] = (Console.ReadLine());
                Console.WriteLine("coloque a cor do produto aqui: ");
                corproduto[volta] = (Console.ReadLine());
                Console.WriteLine("coloque o tamanho do produto aqui (pequeno, médio ou grande): ");
                tamanhoproduto[volta] = (Console.ReadLine());
                Console.WriteLine("coloque o preço do produto aqui: ");
                precoproduto[volta] = double.Parse(Console.ReadLine());
            }
            //próximo for pra imprimir na tela os resultados pro usuário
            for (int volta = 0; volta <= 11; volta++)
            {

                Console.WriteLine(nomeproduto[volta]);
                Console.WriteLine(corproduto[volta]);
                Console.WriteLine(tamanhoproduto[volta]);
                Console.WriteLine(precoproduto[volta]);
            }








        }
    }
}
