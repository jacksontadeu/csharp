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
    internal class Program
    {

        static void CadastrarConta(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.Clear();
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
            string nome = Console.ReadLine();
            cpfs.Add(cpf);
            titulares.Add(nome);
            saldos.Add(0);
            Console.WriteLine("#########################################");
            Console.WriteLine();
            Console.WriteLine("Cadastro realizado com sucesso!!!");
            Console.WriteLine();
            Console.WriteLine("#########################################");
            Console.ReadKey();
            Console.Clear();
        }
        
        static void DeletarConta(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.Clear();
            int deletaConta = 0;
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
                else if (cpfs.Count ==0)
                {
                    Console.WriteLine("#########################################");
                    Console.WriteLine();
                    Console.WriteLine("CPF não cadastrado!!!");
                    Console.WriteLine();
                    Console.WriteLine("#########################################");
                    Console.ReadKey();
                    Console.Clear();
                    break;             
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
            if (deletaConta < 0)
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

                Console.WriteLine("#########################################");
                Console.WriteLine();
                Console.WriteLine("Conta Removida com Sucesso!!!");
                Console.WriteLine();
                Console.WriteLine("#########################################");
                Console.ReadKey();
                Console.Clear();
            }
            else
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
            if (!cpfs.Any())
            {
                Console.WriteLine("#########################################");
                Console.WriteLine();
                Console.WriteLine("Não há contas a serem exibidas!!!");
                Console.WriteLine();
                Console.WriteLine("#########################################");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {


                for (int i = 0; i < cpfs.Count; i++)
                {

                    if (cpfs.Count != 0)
                    {
                        Console.WriteLine("##################################################################");
                        Console.WriteLine();
                        Console.WriteLine($"CPF: {cpfs[i]} | Titular: {titulares[i]} | Saldo: R$ {saldos[i]:F2}");
                        Console.WriteLine();
                        Console.WriteLine("##################################################################");
                       
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
           
        }
            
        static void RealizarSaque(List<string> cpfs, List<double> saldos)
        {
            Console.Clear();
            int realizaSaque = 0;
            double saque;
            Console.Write("Digite o CPF do titular: ");
            string cpf = Console.ReadLine();
            for (int i = 0; i < cpfs.Count; i++)
            {
                realizaSaque = cpfs.FindIndex(d => d == cpf);
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
                else if (realizaSaque >=0)
                {
                    Console.Write("Digite o valor do saque: ");
                    saque = double.Parse(Console.ReadLine());
                    if (saldos[realizaSaque] >= saque)
                    {
                        saldos[realizaSaque] -= saque;
                        Console.WriteLine("##########################################");
                        Console.WriteLine();
                        Console.WriteLine($"Valor do saque: R$ {saque:F2}");
                        Console.WriteLine($"Saldo atual: R$ {saldos[realizaSaque]:F2}");
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
                else
                {
                    break;
                }
            }
            
        }

        static void RealizarDeposito(List<string> cpfs, List<double> saldos)
        {
            Console.Clear();
            int realizaDeposito = 0;
            Console.Write("Digite o CPF do titular: ");
            string cpf = Console.ReadLine();
            for (int i = 0; i < cpfs.Count; i++)
            {
                realizaDeposito = cpfs.FindIndex(d => d == cpf);
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
                else if(realizaDeposito >= 0)
                {
                    Console.Write("Digite o valor do deposito: ");
                    double deposito = double.Parse(Console.ReadLine());

                    if (cpfs.Contains(cpf))
                    {
                        saldos[realizaDeposito] += deposito;
                        Console.WriteLine("######################################");
                        Console.WriteLine();
                        Console.WriteLine($"Valor do depósito: R$ {deposito:F2}");
                        Console.WriteLine($"Saldo atual: R$ {saldos[realizaDeposito]:F2}");
                        Console.WriteLine("Depósito realizado com sucesso!!!");
                        Console.WriteLine();
                        Console.WriteLine("######################################");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    break;
                }
            }
            

        }
        static void TotalArmazenadoNoBanco(List<string> cpfs, List<double> saldos)
        {
            Console.Clear();
            double totalBanco = saldos.Sum();
            Console.WriteLine("#####################################################");
            Console.WriteLine();
            Console.WriteLine($"O valor armazenado no caixa no banco R$ {totalBanco:f2}");
            Console.WriteLine();
            Console.WriteLine("#####################################################");
            Console.ReadKey();
            Console.Clear();
        }
        static void ManutencaoContas(List<string> cpfs, List<double> saldos)
        {
            Console.Clear();
            int opcao;
            do
            {
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
                        RealizarSaque(cpfs, saldos);
                        break;
                    case 2:
                        RealizarDeposito(cpfs, saldos);
                        break;
                    case 3:
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


        static void Main(string[] args)
        {
            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<double> saldos = new List<double>();

            int opcao;
            do
            {

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
                        CadastrarConta(cpfs, titulares, saldos);
                        break;
                    case 2:
                        DeletarConta(cpfs, titulares, saldos);
                        break;
                    case 3:
                        ExibirContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        ManutencaoContas(cpfs, saldos);
                        break;
                    case 5:
                        TotalArmazenadoNoBanco(cpfs, saldos);
                        break;
                    case 0: break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente!!!");
                        break;

                }
            }
            while (opcao != 0);

        }
    }
}


    



