using BatalhaNaval.Model;
using System.Runtime.CompilerServices;
using System.Xml;

namespace BatalhaNaval;
public class Program
{
    public static void Main(string[] args)
    {
        BatalhaNavalRun();
    }

    public static void BatalhaNavalRun()
    {
        char[] jogo = new char[64];
        char[] mapa1 = new char[64];
        int partida = 1;
        int i = 0;
        Console.WriteLine();
        Console.WriteLine("============BATALHA NAVAL=============");
        Console.WriteLine();
        Jogador jogador1 = new Jogador();
        Console.Write("Digite o nome do jogador (1): ");
        jogador1.Nome = Console.ReadLine().ToUpper();
        Console.WriteLine();

        Jogador jogador2 = new Jogador();
        Console.Write("Digite o nome do jogador (2): ");
        jogador2.Nome = Console.ReadLine().ToUpper();
        Console.WriteLine();

        Console.WriteLine($"{jogador1.Nome} e {jogador2.Nome} sejam bem-vindos a BATALHA NAVAL!!!");
        Console.ReadKey();

        MapaNaviosJogador1 mapa = new MapaNaviosJogador1();
        Tabuleiro tabuleiro = new Tabuleiro();
        mapa.IniciarMapa(mapa1);
        tabuleiro.IniciarTab(jogo, mapa1);

        while (true)
        {
            tabuleiro.IniciarTab(jogo, mapa1);
            for (i = 0; i < jogo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("============BATALHA NAVAL=============");
                    Console.WriteLine();
                    Console.WriteLine($"Partida {partida}");
                    tabuleiro.TabuleiroJogo(jogo, mapa1);
                    Console.WriteLine($"           Jogada de {jogador1.Nome}  ");
                    Console.WriteLine($"    Pontuação: {jogador1.Nome} {jogador1.Pontos}    {jogador2.Nome} {jogador2.Pontos}");
                    jogador1.RealizarJogadas(jogo, mapa1);
                    int vencedor = jogador1.Vencedor();
                    if (vencedor == 1)
                    {
                        Console.WriteLine($"{jogador1.Nome} foi o Vencedor!!!");
                        jogador1.Vitorias++;
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("============BATALHA NAVAL=============");
                    Console.WriteLine();
                    Console.WriteLine($"Partida {partida}");
                    tabuleiro.TabuleiroJogo(jogo, mapa1);
                    Console.WriteLine($"           Jogada de {jogador2.Nome}  ");
                    Console.WriteLine($"    Pontuação: {jogador1.Nome} {jogador1.Pontos}    {jogador2.Nome} {jogador2.Pontos}");
                    jogador2.RealizarJogadas(jogo, mapa1);
                    int vencedor = jogador2.Vencedor();
                    if (vencedor == 1)
                    {
                        Console.WriteLine($"{jogador2.Nome} foi o Vencedor!!!");
                        jogador2.Vitorias++;
                        break;
                    }
                }

            }
            Console.Write("Deseja jogar outra partida (S / N): ");
            char opcao = char.Parse(Console.ReadLine().ToUpper());
            if (opcao == 'S')
            {
                partida++;
                jogador1.Pontos = 0;
                jogador2.Pontos = 0;
                continue;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("=====Estatistica do Jogo====");
                Console.WriteLine();
                Console.WriteLine(jogador1.ToString());
                Console.WriteLine(jogador2.ToString());
                Console.ReadKey();
                break;
            }

        }

    }
}
    
    
    
