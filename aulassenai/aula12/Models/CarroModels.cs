namespace aula12.Models
{
    public class CarroModels
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }

        public bool Ligado { get; set; }

        //pq tem que botar isso?
        public MotorModels Motor {get; set;}
    }
}