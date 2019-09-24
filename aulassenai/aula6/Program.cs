using System;

namespace aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            // chamamos nossa primeira função
            Console.WriteLine(BomDia());
            //chamamos a função do tipo VOID (sem retorno)
            ImprimeDataHora();
            // chamamos nossa função que calcula a média
            double [] numeros = { 2, 5, 2, 8, 9, 5 };
            Console.WriteLine(CalculaMedia(numeros) );

            // chamamos a função de soma
            Console.WriteLine( CalculaSoma(numeros) );
        }
        /// <summary>
        /// função que escreve bom dia para o usuário
        /// </summary>
        /// <returns> Retorna "olá! Bom dia!"</returns>
        static string BomDia(){
            return "olá! bom dia";
        }

        /// <summary>
        /// retorna função que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao">um testo qualquer (sobrecarga de metodo)</param>
        /// <returns>saudação de acordo com o horário</returns>
        static string BomDia(string saudacao){
          int hora= DateTime.Now.Hour;
            if(hora <=12 && hora>=6){
                saudacao = "bom dia";
            }else if(hora> 12 && hora <= 18){
                saudacao = "bom dia";
            }else{
                saudacao= "Boa noite";

            }
            return  saudacao ;
        }
        
        /// <summary>
        /// retorna Data e hora atuais
        /// </summary>
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour);
        }
       
        /// <summary>
        ///  função que calcula que a média de um vetor
        /// </summary>
        /// <param name="valores">vetor com valores</param>
        /// <returns>média dos valores</returns>
        static double CalculaMedia (double [] valores){
            double resultado= 0;
            for(int i = 0; i < valores.Length ; i ++){
              resultado += valores[i];
            }
            resultado= resultado / valores.Length;

            return resultado;
        }
          
          /// <summary>
          /// calcula a soma de um vetor
          /// </summary>
          /// <param name="valores"></param>
          /// <returns></returns>
           static double CalculaSoma (double [] valores){
            double resultado= 0;
            for(int i = 0; i < valores.Length ; i ++){
              resultado += valores[i];
            }
            resultado= resultado / valores.Length;

            return resultado;
        }
    }
}
