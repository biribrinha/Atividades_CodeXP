namespace ex2.Models
{
    public class CelularModels
    {
        /*2. Criar um objeto de um celular, com as propriedades cor,
         modelo, tamanho.
        Com os métodos, ligar, desligar, fazer ligação,
        enviar mensagem. Só será
        possível executar tais métodos se o celular estiver ligado. */

        public string Cor { get; set; } //Cor do celular//
         public string Modelo { get; set; } //modelo do celular//
          public string Tamanho { get; set; } //Tamanho do celular//
          public bool Ligado {get; set;}  // ligar o celular
    }
}