using System;
using System.Collections.Generic;
using ex2.Models;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularModels Celulinho = new CelularModels("azul", "motorola", "pequeno");
            //instanciamos nossa classe
            //sem passar parametros utilizando sobrecarga
            CelularModels produto_sobrecarga = new CelularModels();
            produto_sobrecarga.Cor = "rosa";
            produto_sobrecarga.Modelo = "apple";
            produto_sobrecarga.Tamanho = "grande";

            //fazendo a lista já com argumentos feitos

            List<CelularModels> prod = new List<CelularModels>();
            //prod é só uma variável

            prod.Add(new CelularModels("azul", "motorola", "pequeno"));
            prod.Add(new CelularModels("azul", "motorola", "pequeno"));
            prod.Add(new CelularModels("azul", "motorola", "pequeno"));
            prod.Add(new CelularModels("azul", "motorola", "pequeno"));
            prod.Add(new CelularModels("azul", "motorola", "pequeno"));
            prod.Add(new CelularModels("azul", "motorola", "pequeno"));

            //lemos os dados da nossa lista (foreach)

            foreach (CelularModels c in prod)
            {
                //como o vetor começa a contar por zero, é interessante colocar um console. w vazio
                //pois:
                System.Console.WriteLine(); // [0]
                System.Console.WriteLine(c.Cor); // [1]
                System.Console.WriteLine(c.Modelo); // [2]
                System.Console.WriteLine(c.Tamanho); //[3]
                System.Console.WriteLine();// [4]

            }

            //chamamos através do indice do objeto (lembrando que começa do zero)
            System.Console.WriteLine(prod[2].Modelo);







        }
    }
}
