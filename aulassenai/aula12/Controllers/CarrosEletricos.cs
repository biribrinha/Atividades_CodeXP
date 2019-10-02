using aula12.Models;

namespace aula12.Controllers
{
    public class CarrosEletricos
    {
        //declarando objeto carroeletricomodel
        // declarar um objeto é criar um objeto através de uma classe
        CarroEletricoModels carroEletrico = new CarroEletricoModels();

        //declarando obketo motormodels

        MotorModels motor = new MotorModels();

          public void CarroEletrico (float carga){
              if (carroEletrico.Bateria < 100)
              {
                 
                  carroEletrico.Bateria += carga;
                  //É O MESMO QUE... 
                  //carroeletrico.Bateria = carroeletrico.Bateria + carga;

              }else
              {
                  System.Console.WriteLine("A bateria do carro já está conpleta! pode viajarrrrr :)");
              }
          }

          public float StatusBateria()
          {
              return carroEletrico.Bateria;
          }

    }
  
}