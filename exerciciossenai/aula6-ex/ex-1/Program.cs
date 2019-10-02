using System;

namespace aula6_ex
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o CNPJ: ");
            string cnpj = Console.ReadLine();

            Console.WriteLine(ValidaCNPJ(cnpj));

        }

        static bool ValidaCNPJ(string cnpjUsuario)
        {

            bool resultado = false;
            int[] v1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cnpjCalculo = "";
            int calculo = 0;

        // isso AQUI foi usado pra tirar e substituir caracteres indesejados, por exemplo
        //o "-" foi substituido por ""
        // QUE SIGNIFICA NADA, PQ NAO PODE BOTAR - E SÓ TIRA MSM
         cnpjUsuario = cnpjUsuario.Replace(" ", "");
         cnpjUsuario = cnpjUsuario.Replace("-", "");
         cnpjUsuario = cnpjUsuario.Replace("/", "");

          cnpjCalculo = cnpjUsuario.Substring(0, 9);

            for(int i= 0; i <= 8; i++){
                calculo += int.Parse( cnpjCalculo[i].ToString()) * v1[i];
            }

         
         
          return resultado;
        }
    

    }
}
