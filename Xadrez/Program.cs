using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Models;

namespace Xadrez
{
    public class Program
    {
        static void Main(string[] args)
        {
            Xadrez();
            
        }
        public static void Xadrez()
        {
            char[] t = new char[64];
            int cont = 0;
            Console.WriteLine("===================JOGO DE XADREZ=================");
            Console.Write("Digite o nome do Jogador (1): ");
            string nomeJogador1 = Console.ReadLine().ToUpper();
            Jogador player1 = new Jogador(nomeJogador1);
            Console.Write("Digite o nome do Jogador (2): ");
            string nomeJogador2 = Console.ReadLine().ToUpper();
            Jogador player2 = new Jogador(nomeJogador2);
            TabuleiroView tabuleiro = new TabuleiroView();
            int opcao = 0;
            tabuleiro.IniciarTabuleiro(t);

            while (opcao != 999)
            {
                if (cont % 2 == 0)
                {
                    tabuleiro.MostrarTabuleiro(t);
                    Console.WriteLine($"Jogada de {player1.Nome}");
                    tabuleiro.RealizarJogadas(t);
                }
                else
                {
                    tabuleiro.MostrarTabuleiro(t);
                    Console.WriteLine($"Jogada de {player2.Nome}");
                    tabuleiro.RealizarJogadas(t);
                }
                cont++;
            }
        }
    }
}
