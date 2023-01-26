namespace LocateCar.Model
{
    public class Car
    {
        public string Marca { get; set; } = null!;
        public bool IsAvailable { get; set; } = true;
        public string Placa { get; set; } = null!;

        public Car(string marca, string placa)
        {
            Marca = marca;
            Placa = placa;
        }
    }
}