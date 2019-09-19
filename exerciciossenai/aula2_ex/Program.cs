using System;

namespace aula2_ex
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int salario, despesa, total;
            Console.Write("escreva seu salário aqui: ");
            salario = int.Parse(Console.ReadLine());
             Console.Write("escreva suas despesas aqui: ");
             despesa = int.Parse(Console.ReadLine());
            total = (salario - despesa);
            
            if(total >= 0){
               Console.WriteLine("SOBROU GRANA AE");
            } 
            else{
                Console.WriteLine("não sobrou grana não... tem que economizar :c");
            }
        }
    }
}
