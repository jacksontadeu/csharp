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
        while (true)
        {
            if (jogo[campo] != ' ')
            {
                Console.WriteLine("Jogada Inválida, digite novamente!!!");
                
                Console.Write("Digite o campo: ");
                campo = int.Parse(Console.ReadLine());
            }
            else if (mapa1[campo] != ' ')
            {
                jogo[campo] = mapa1[campo];
                break;
            }
            else
            {
                jogo[campo] = '*';
                break;
            }
        }
    }
    public void RegistrarPontucao(char[] jogo, char[] mapa1)
    {
        if (mapa1[campo] != ' ')
            this.Pontos++;
        
    }
    
}

    



