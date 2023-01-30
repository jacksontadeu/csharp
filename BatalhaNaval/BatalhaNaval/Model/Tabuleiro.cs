namespace BatalhaNaval.Model;

public class Tabuleiro
{
    public void TabuleiroJogo(char[] jogo , char[]mapa1)
    {
        Console.WriteLine("    _______________________________________________");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("0  |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  7", jogo[0], jogo[1], jogo[2],jogo[3], jogo[4], jogo[5], jogo[6], jogo[7]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("8  |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  15", jogo[8], jogo[9], jogo[10], jogo[11], jogo[12], jogo[13], jogo[14], jogo[15]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("16 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  23", jogo[16], jogo[17], jogo[18], jogo[19], jogo[20], jogo[21], jogo[22], jogo[23]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("24 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  31", jogo[24], jogo[25], jogo[26], jogo[27], jogo[28], jogo[29], jogo[30], jogo[31]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("32 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  39", jogo[32], jogo[33], jogo[34], jogo[35], jogo[36], jogo[37], jogo[38], jogo[39]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("40 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  47", jogo[40], jogo[41], jogo[42], jogo[43], jogo[44], jogo[45], jogo[46], jogo[47]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("48 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  55", jogo[48], jogo[49], jogo[50], jogo[51], jogo[52], jogo[53], jogo[54], jogo[55]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("56 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  63", jogo[56], jogo[57], jogo[58], jogo[59], jogo[60], jogo[61], jogo[62], jogo[63]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
    }
    public void IniciarTab(char[] jogo, char[] mapa1)
    {
        for (int i = 0; i < jogo.Length; i++)
        {
            jogo[i] = ' ';
        }
    }
   
}
