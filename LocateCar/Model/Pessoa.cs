namespace LocateCar.Model
{
    public class Pessoa
    {
        public string Cpf { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string  Email { get; set; } = null!;

        public Pessoa(string cpf, string nome, string email)
        {
            Cpf = cpf;
            Nome = nome;
            Email = email;
        }
    }

}