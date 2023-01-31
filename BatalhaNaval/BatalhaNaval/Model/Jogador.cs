using System.Runtime.CompilerServices;

namespace BatalhaNaval.Model;

public class Jogador
{
    public string Nome { get; set; } = null!;
    public int Vitorias { get; set; }
    public int Pontos { get; set; }

    int campo;
    public void RealizarJogadas(char[] jogo, char[] mapa1)
    {
        Console.Write("Digite o campo: ");
        campo = int.Parse(Console.ReadLine());
        VerificarJogada(jogo, mapa1);

        if (mapa1[campo] != ' ')
        {
            jogo[campo] = mapa1[campo];
            RegistrarPontuacao(jogo, mapa1);
        }
        else
        {
            jogo[campo] = '*';
        }
        
    }
    public void VerificarJogada(char[] jogo, char[] mapa1)
    {
        while (jogo[campo] != ' ')
        {
            if (jogo[campo] == ' ')
            {
                break;
            }
            else
            {
                Console.WriteLine("Jogada Inválida, digite novamente!!!");
                Console.Write("Digite o campo: ");
                campo = int.Parse(Console.ReadLine());
            }
        }

    }
    public bool AcertarJogada(char[] jogo, char[] mapa1)
    {
        if (mapa1[campo] == ' ')
            return false;
        return true;
    }
    public void RegistrarPontuacao(char[] jogo, char[] mapa1)
    {
        if (mapa1[campo] != ' ')
            this.Pontos++;

    }
    public int Vencedor()
    {
        if (Pontos == 6)
            return 1;
        return 0;
    }
    public override string ToString()
    {
        string info = $"Nome: {this.Nome}, Vitoria(s): {this.Vitorias}";
        return info;
    }

}








