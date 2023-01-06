using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Threading;

namespace ByteBank
{
    public class Program
    {

        static void CadastrarConta(List<string> cpfs, List<string> titulares, List<double> saldos, List<string> senhas)
        {
            Console.Clear();
            Console.WriteLine( );
            Console.WriteLine("============CADASTRO DE CONTAS==============");
            Console.WriteLine();
            Console.Write("Digite o CPF do titular: ");
            string cpf = Console.ReadLine();
            while (true)
            {
                if (cpf.Length != 11)
                {
                    Console.WriteLine("CPF inválido!!!");
                    Console.WriteLine("Digite novamente!!!");
                    Console.Write("Digite o CPF do titular: ");
                    cpf = Console.ReadLine();
                }
                else if (cpfs.Contains(cpf))
                {
                    Console.WriteLine("CPF já existe no cadastro!!!");
                    Console.WriteLine("Digite novamente!!!");
                    Console.Write("Digite o CPF do titular: ");
                    cpf = Console.ReadLine();

                }
                else
                {
                    break;
                }
            }
            Console.Write("Digite o Nome do Titular: ");
            string nome = Console.ReadLine().ToUpper();
            Console.Write("Digite sua senha (4 Dígitos somente números): ");
            string senha = getPassword();
            while (true)
            {
                if (senha.Length != 4)
                {
                    Console.WriteLine("Senha inválida, tente novamente!!!");
                    Console.Write("Digite sua senha (4 Dígitos somente números): ");
                    senha = getPassword();
                }
                else
                {
                    break;
                }
            }

            cpfs.Add(cpf);
            titulares.Add(nome);
            saldos.Add(0);
            senhas.Add(senha);
            Console.WriteLine("#########################################");
            Console.WriteLine();
            Console.WriteLine("Cadastro realizado com sucesso!!!");
            Console.WriteLine();
            Console.WriteLine("#########################################");
            Console.ReadKey();
            Console.Clear();
        }

        static void DeletarConta(List<string> cpfs, List<string> titulares, List<double> saldos, List<string> senhas)
        {
            Console.Clear();
            int deletaConta = 0;
            Console.WriteLine();
            Console.WriteLine("============DELEÇÃO DE CONTAS==============");
            Console.WriteLine();
            Console.Write("Digite o CPF do titular: ");
            string cpf = Console.ReadLine();
            while (true)
            {
                if (cpf.Length != 11)
                {
                    Console.WriteLine("CPF inválido!!!");
                    Console.WriteLine("Digite novamente!!!");
                    Console.Write("Digite o CPF do titular: ");
                    cpf = Console.ReadLine();
                }
                
                else
                {
                    break;
                }

            }
            for (int i = 0; i < cpfs.Count; i++)
            {
                deletaConta = cpfs.FindIndex(d => d == cpf);
            }
            if (!cpfs.Any() || deletaConta <0)
            {
                Console.WriteLine("#########################################");
                Console.WriteLine();
                Console.WriteLine("CPF não cadastrado!!!");
                Console.WriteLine();
                Console.WriteLine("#########################################");
                Console.ReadKey();
                Console.Clear();
            }

            else if (cpfs[deletaConta].Equals(cpf) && saldos[deletaConta] == 0)
            {
                cpfs.Remove(cpfs[deletaConta]);
                saldos.Remove(saldos[deletaConta]);
                titulares.Remove(titulares[deletaConta]);
                senhas.Remove(senhas[deletaConta]);
                Console.WriteLine("#########################################");
                Console.WriteLine();
                Console.WriteLine("Conta Removida com Sucesso!!!");
                Console.WriteLine();
                Console.WriteLine("#########################################");
                Console.ReadKey();
                Console.Clear();
            }
            else if (cpfs[deletaConta].Equals(cpf) && saldos[deletaConta] != 0)
            {
                Console.WriteLine("##########################################");
                Console.WriteLine();
                Console.WriteLine($"A conta possui saldo R$ {saldos[deletaConta]:F2}");
                Console.WriteLine("Impossivel excluir a conta!!!");
                Console.WriteLine();
                Console.WriteLine("##########################################");
                Console.ReadKey();
                Console.Clear();
            }


        }
        static void ExibirContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("==================EXIBIÇÃO DE CONTAS================");
            Console.WriteLine();
            if (!cpfs.Any())
            {                
                Console.WriteLine();
                Console.WriteLine("Não há contas a serem exibidas!!!");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                int i = 0;
                for ( i = 0; i < cpfs.Count; i++)
                {
                    if (cpfs.Count != 0)
                    {                        
                        Console.WriteLine();
                        Console.WriteLine($"CPF: {cpfs[i]} | Titular: {titulares[i]} | Saldo: R$ {saldos[i]:F2}");
                        Console.WriteLine();                   
                        Console.WriteLine();                   

                    }
                }
                Console.WriteLine($"Total de {i} conta(s) cadastrada(s)");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ManutencaoContas(List<string> cpfs, List<string> titulares, List<double> saldos, List<string> senhas)
        {
            Console.Clear();
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==========MENU BYTEBANK==========");
                Console.WriteLine();
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Transferir");
                Console.WriteLine("0 - Voltar ao Menu Anterior");
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.Write("Digite a opcão desejada: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        RealizarSaque(cpfs, titulares, saldos, senhas);
                        break;
                    case 2:
                        RealizarDeposito(cpfs, titulares, saldos);
                        break;
                    case 3:
                        RealizarTransferencia(cpfs, titulares, saldos, senhas);
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente!!!");
                        break;
                }

            } while (opcao != 0);
        }
        static void RealizarSaque(List<string> cpfs, List<string> titulares,List<double> saldos, List<string> senhas)
        {
            Console.Clear();
            int realizaSaque = 0;
            double saque;
            Console.WriteLine();
            Console.WriteLine("==================REALIZAR SAQUE================");
            Console.WriteLine();
            Console.Write("Digite o CPF do titular: ");
            string cpf = Console.ReadLine();
            for (int i = 0; i < cpfs.Count; i++)
            {
                realizaSaque = cpfs.FindIndex(d => d == cpf);
            }
            if (realizaSaque < 0)
            {
                Console.WriteLine("#########################################");
                Console.WriteLine();
                Console.WriteLine("CPF não cadastrado!!!");
                Console.WriteLine();
                Console.WriteLine("#########################################");
                Console.ReadKey();
                Console.Clear();

            }
            else if (realizaSaque >= 0)
            {
                Console.Write("Informe a senha: ");
                string senha = getPassword();
                while (true)
                {
                    if (senhas[realizaSaque].Equals( senha))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Senha incorreta, tente novamente!!!");
                        Console.Write("Informe a senha: ");
                        senha = getPassword();
                    }
                }
                Console.Write("Digite o valor do saque: ");
                saque = double.Parse(Console.ReadLine());
                if (saldos[realizaSaque] >= saque)
                {
                    saldos[realizaSaque] -= saque;
                    Console.WriteLine("PROCESSANDO...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("##########################################");
                    Console.WriteLine();
                    Console.WriteLine("===========Comprovante de Saque==========");
                    Console.WriteLine();
                    Console.WriteLine($"Nome do Titular: {titulares[realizaSaque]}");
                    Console.WriteLine();
                    Console.WriteLine($"Valor do saque: R$ {saque:F2}");                    
                    Console.WriteLine();
                    Console.WriteLine("##########################################");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("##########################################");
                    Console.WriteLine();
                    Console.WriteLine("Saldo Insuficente!!!");
                    Console.WriteLine();
                    Console.WriteLine("##########################################");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
        static void RealizarDeposito(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.Clear();
            int realizaDeposito = 0;
            Console.WriteLine();
            Console.WriteLine("==================REALIZAR DEPÓSITO================");
            Console.WriteLine();
            Console.Write("Digite o CPF do titular: ");
            string cpf = Console.ReadLine();
            for (int i = 0; i < cpfs.Count; i++)
            {
                realizaDeposito = cpfs.FindIndex(d => d == cpf);
            }
            if (realizaDeposito < 0)
            {
                Console.WriteLine("#########################################");
                Console.WriteLine();
                Console.WriteLine("CPF não cadastrado!!!");
                Console.WriteLine();
                Console.WriteLine("#########################################");
                Console.ReadKey();
                Console.Clear();
            }
            else if (realizaDeposito >= 0)
            {
                Console.Write("Digite o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine());

                saldos[realizaDeposito] += deposito;
                Console.WriteLine("PROCESSANDO...");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine();                
                Console.WriteLine("======Comprovante de Depósito=========");
                Console.WriteLine();
                Console.WriteLine($"Nome do Favorecido: {titulares[realizaDeposito]}");
                Console.WriteLine($"Valor do depósito: R$ {deposito:F2}");                
                Console.WriteLine("Depósito realizado com sucesso!!!");
                Console.WriteLine();
                Console.WriteLine("######################################");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void RealizarTransferencia(List<string> cpfs, List<string> titulares, List<double> saldos, List<string> senhas)
        {
            Console.Clear();
            int realizaTransferencia = 0;
            Console.WriteLine();
            Console.WriteLine("==================REALIZAR TRANSFERÊNCIA================");
            Console.WriteLine();
            Console.Write("Digite o CPF de ORIGEM: ");
            string cpf = Console.ReadLine();

            for (int i = 0; i < cpfs.Count; i++)
            {
                realizaTransferencia = cpfs.FindIndex(d => d == cpf);
            }
            if (realizaTransferencia < 0)
            {
                Console.WriteLine("#########################################");
                Console.WriteLine();
                Console.WriteLine("CPF do titular não encontrado!!!");
                Console.WriteLine();
                Console.WriteLine("#########################################");
                Console.ReadKey();
                Console.Clear();
            }
            else if (realizaTransferencia >= 0)
            {
                Console.Write("Informe a senha: ");
                string senha = getPassword();
                while (true)
                {
                    if (senhas[realizaTransferencia].Equals(senha))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Senha incorreta, tente novamente!!!");
                        Console.Write("Informe a senha: ");
                        senha = getPassword();
                    }
                }
                int recebeTransferencia = 0;
                double transferencia;
                Console.Write("Digite o CPF do FAVORECIDO: ");
                string cpf1 = Console.ReadLine();
                for (int i = 0; i < cpfs.Count; i++)
                {
                    recebeTransferencia = cpfs.FindIndex(e => e == cpf1);
                }
                if (recebeTransferencia < 0)
                {
                    Console.WriteLine("#########################################");
                    Console.WriteLine();
                    Console.WriteLine("CPF do destinatário não encontrado!!!");
                    Console.WriteLine();
                    Console.WriteLine("#########################################");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (recebeTransferencia >= 0)
                {
                    Console.Write("Digite o valor da transferência: ");
                    transferencia = double.Parse(Console.ReadLine());

                    if (transferencia > saldos[realizaTransferencia])
                    {
                        Console.WriteLine("PROCESSANDO...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("##########################################");
                        Console.WriteLine();
                        Console.WriteLine("Saldo Insuficente!!!");
                        Console.WriteLine();
                        Console.WriteLine("##########################################");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        saldos[realizaTransferencia] -= transferencia;
                        saldos[recebeTransferencia] += transferencia;
                        Console.WriteLine("PROCESSANDO...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine();
                        Console.WriteLine("======Comprovante de Transferência=========");
                        Console.WriteLine();
                        Console.WriteLine($"Nome do Titular: {titulares[realizaTransferencia]}");
                        Console.WriteLine($"Valor da transferencia: R$ {transferencia:F2}");
                        Console.WriteLine($"Nome do Favorecido: {titulares[recebeTransferencia]:F2}");
                        Console.WriteLine();
                        Console.WriteLine("Transferência realizada com sucesso!!!");
                        Console.WriteLine();
                        Console.WriteLine("######################################");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }

        static void TotalArmazenadoNoBanco(List<string> cpfs, List<double> saldos)
        {
            Console.WriteLine("PROCESSANDO...");
            Thread.Sleep(3000);
            Console.Clear();
            double totalBanco = saldos.Sum();
            int i = 0;
            for (i = 0; i < cpfs.Count; i++)
            {

            }
            Console.WriteLine();
            Console.WriteLine("==================CAIXA DO BANCO================");                      
            Console.WriteLine();
            Console.WriteLine($"O valor armazenado no caixa no banco R$ {totalBanco:f2}");
            Console.WriteLine();
            Console.WriteLine($"Total de {i} conta(s) cadastrada(s)");
            Console.WriteLine("=================================================");
            Console.ReadKey();
            Console.Clear();
        }
        static string getPassword()
        {
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    //pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            Console.WriteLine();
            return pass;
        }
        static void Main(string[] args)
        {
            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<double> saldos = new List<double>();
            List<string> senhas = new List<string>();
           
            int opcao;
            do
            {
                Console.WriteLine();
                Console.WriteLine("==========MENU BYTEBANK==========");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastrar Nova Conta");
                Console.WriteLine(" 2 - Deletar Conta");
                Console.WriteLine(" 3 - Exibir Contas");
                Console.WriteLine(" 4 - Manutenção da Conta");
                Console.WriteLine(" 5 - Valor Armazenado no Banco");
                Console.WriteLine(" 0 - FIM");
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CadastrarConta(cpfs, titulares, saldos, senhas);
                        break;
                    case 2:
                        DeletarConta(cpfs, titulares, saldos, senhas);
                        break;
                    case 3:
                        ExibirContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        ManutencaoContas(cpfs, titulares, saldos, senhas);
                        break;
                    case 5:
                        TotalArmazenadoNoBanco(cpfs, saldos);
                        break;
                    case 0:
                        Console.WriteLine("Encerrando o sistema!!!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente!!!");
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}




    



