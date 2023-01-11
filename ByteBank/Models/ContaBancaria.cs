namespace ByteBank.Models
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public string Cpf { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public string TipoConta { get; set; }
        public int Id { get; set; }
        public string Senha { get; set; }
        public bool EstaAtiva { get; set; }


        public ContaBancaria(string titular, string cpf, string tipoConta, int id, string senha)
        {
            Titular = titular;
            Cpf = cpf;
            TipoConta = tipoConta;
            Id = id;
            Saldo = 0.0;
            EstaAtiva = true;
            this.ConcederLimite();
        }
        public bool Depositar(double deposito)
        {
            if (!EstaAtiva)
                return false;

            Saldo += deposito;
            return true;

        }
        public bool Sacar(double saque)
        {
            if (!EstaAtiva)
                return false;

            if (Saldo < saque)            
                return false;

            Saldo -= saque;
            return true;            
        }
        public bool Transferir(double valor,ContaBancaria contaDestino)
        {
            if (!contaDestino.EstaAtiva)
                return false;   

            if (!this.Sacar(valor))
            {
                return false;
            }
            
                return contaDestino.Depositar(valor);
                        
        }
        public bool ConcederLimite()
        {
            if (!EstaAtiva)
                return false;

            if (TipoConta.Equals("CC"))
                this.Limite = 1500.00;
            return true;
        }
        public void FecharConta()
        {

        }
        public void StatusConta()
        {
            System.Console.WriteLine($"Nome do Titular: {this.Titular}");
            System.Console.WriteLine($"CPF do Titular.: {this.Cpf}");
            System.Console.WriteLine($"Número da Conta: {this.Id}");
            System.Console.WriteLine($"Tipo de Conta..: {this.TipoConta}");
            System.Console.WriteLine($"Saldo da Conta.: {this.Saldo:F2}");
            System.Console.WriteLine($"Limite da Conta: {this.Limite:F2}");
            System.Console.WriteLine($"Saldo Total....: {this.Saldo + this.Limite:f2}");
        }
    }
}
