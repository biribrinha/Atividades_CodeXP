using System;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            // // laço contado - for - INCREMENTO (+) //
            // for (int cont = 1; cont <= 100; cont++)
            // {

//     // VERIFICAMOS SE O NÚMERO É DIFERENTE DE PAR //
//     if (cont % 2 != 0)
//     {
//         Console.WriteLine(" FOR - 0 " + cont);


//     }
// }
// // laço contado - for - DECRIMENTO (+) //

// for (int cont = 1; cont <= 100; cont++)
// {
//     if (cont % 2 != 0)
//     {
//         Console.WriteLine(cont);
//     }
// }
// // VERIFICAMOS SE O NÚMERO É DIFERENTE DE PAR //
// for (int cont = 100; cont >= 0; cont--)
// {
//     if (cont % 2 != 0)
//     {
//         Console.WriteLine(cont);
//     }
// }

// LAÇO CONDICIONAL - WHILE 

/*double acumuladora = 0;
    double nota = 0;
    int cont = 0;
    string sair = "";

    while (sair != "sim")
    {
        Console.Write("digite a nota de um aluno: ");
        nota = double.Parse(Console.ReadLine());

        acumuladora += nota;
        cont++;

        Console.Write("deseja sair da aplicação? sim/não");
        sair = Console.ReadLine().ToLower();
    }
    Console.WriteLine("media das notas: " + (acumuladora / cont));

    int ninteirinho;
    int acumular = 0;
    int contadora = 1;
    do 
    {
            Console.Write("digite um número aqui: ");
        ninteirinho = int.Parse(Console.ReadLine());

    if(ninteirinho %3 == 0){


    } 


}
}
}
}
