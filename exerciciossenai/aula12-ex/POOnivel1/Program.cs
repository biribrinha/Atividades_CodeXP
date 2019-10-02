using System;
using aula12_ex.Controllers;

namespace aula12_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //terceira e última pasta a mecher, aqui é juntado tudo o que foi feito
            PessoaControllers Imc = new PessoaControllers();
            Imc.CadastroPessoa();
             Imc.ImprimePessoa();
              Imc.ImcPessoa();
               

        }
    }
}
