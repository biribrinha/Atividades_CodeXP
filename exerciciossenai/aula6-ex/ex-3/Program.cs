using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Criar uma função do tipo void
            // que escreve no console o atual dia da semana
           //usando Datetime
          
            ImprimeDiaSemana();
            }
                  static void ImprimeDiaSemana(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.DayOfWeek);

        }
    }
}
