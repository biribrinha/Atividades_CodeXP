using System.Collections.Generic;

namespace ex2.Models
{
    public class CelularModels
    {
      //pegar um ex feito de outra aula e fazer em tabela
        public string Cor { get; set; } //Cor do celular//
        public string Modelo { get; set; } //modelo do celular//
        public string Tamanho { get; set; } //Tamanho do celular//


        //utilizamos sobrecarga para poder instanciar 
        //passando ou não os atributos

        public CelularModels()
        {

        }

        public CelularModels(string cor, string modelo, string tamanho)
        {
            //botar o this. e tudomais
            this.Cor = cor;
            this.Modelo = modelo;
            this.Tamanho = tamanho;
        }

    }
}