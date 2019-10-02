using System;

namespace aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] v1 = {"A", "B", "C"};

            // laço  FOREACH (para cada)
            // é o "Console.Writeline" do vetor
            foreach(string xpto in v1){
                    Console.WriteLine(xpto);
            }
        }
    }
}
