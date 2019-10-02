namespace aula12_ex.models
{
    public class PessoaModels
    {
        //primeira pasta a ser usada, ela serve pra declarar os objetos]
        
            /*Crie uma classe chamada Pessoa, que possua como
  atributos nome, idade, peso (em quilogramas) e altura (em metros). Adicione métodos para
  ler os dados digitados pelo usuário e escrever os mesmos no console. Além disso, crie um
  método que seja capaz de calcular o Índice de Massa Corporal (IMC). O cálculo é feito através
  da fórmula IMC = peso/altura², que mostre o resultado: */

        public string Nome { get; set; } //nome da pessoa//
        public int Idade { get; set; }   //idade da pessoa//
        public double Peso { get; set; }  //peso da pessoa//
        public double Altura { get; set; } //altura da pessoa//
        
    }
}