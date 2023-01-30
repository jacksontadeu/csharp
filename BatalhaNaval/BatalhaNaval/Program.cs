using BatalhaNaval.Model;

namespace BatalhaNaval;
public class Program
{
    public static void Main(string[] args)
    {
        BatalhaNaval();
    }

    public static void BatalhaNaval()
    {
        char[] jogo = new char[64];
        char[] mapa1 = new char[64];
        int cont = 0;
        Console.WriteLine();
        Console.WriteLine("============BATALHA NAVAL=============");
        Console.WriteLine();
        Jogador jogador1 = new Jogador();
        Console.Write("Digite o nome do jogador (1): ");
        jogador1.Nome = Console.ReadLine().ToUpper();
        Console.WriteLine();

        Jogador jogador2 = new Jogador();
        Console.Write("Digite o nome do jogador (2): ");
        jogador2.Nome = Console.ReadLine().ToUpper() ;
        Console.WriteLine();

        Console.WriteLine($"{jogador1.Nome} e {jogador2.Nome} sejam bem-vindos a BATALHA NAVAL!!!");
        Console.ReadKey();

        MapaNaviosJogador1 mapa = new MapaNaviosJogador1();
        Tabuleiro tabuleiro = new Tabuleiro();
        mapa.IniciarMapa(mapa1);
        tabuleiro.IniciarTab(jogo, mapa1);
        while (true)
        {
            Console.Clear();
            Console.WriteLine("============BATALHA NAVAL=============");
            Console.WriteLine();
            tabuleiro.TabuleiroJogo(jogo, mapa1);
            if (cont % 2 == 0)
            {
                Console.WriteLine($"Jogada de {jogador1.Nome} ============== Pontuação: {jogador1.Pontos}");
                jogador1.RealizarJogadas(jogo, mapa1);
                jogador1.RegistrarPontucao(jogo, mapa1);
            }
            if (cont % 2 == 1)
            {
                Console.WriteLine($"Jogada de {jogador2.Nome} ============== Pontuação: {jogador2.Pontos}");
                jogador2.RealizarJogadas(jogo, mapa1);
                jogador2.RegistrarPontucao(jogo, mapa1);
            }
            cont++;
        }
    }
}