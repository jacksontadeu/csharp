namespace BatalhaNaval.Model;

public class MapaNaviosJogador1
{
    public void Mapa(char[] mapa1)
    {
        Console.WriteLine("    _______________________________________________");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("0  |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  7", mapa1[0], mapa1[1], mapa1[2], mapa1[3], mapa1[4], mapa1[5],mapa1[6], mapa1[7]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("8  |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  15", mapa1[8], mapa1[9], mapa1[10], mapa1[11], mapa1[12], mapa1[13], mapa1[14], mapa1[15]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("16 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  23",mapa1[16], mapa1[17], mapa1[18], mapa1[19], mapa1[20], mapa1[21], mapa1[22], mapa1[23]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("24 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  31", mapa1[24], mapa1[25], mapa1[26], mapa1[27], mapa1[28],mapa1[29], mapa1[30], mapa1[31]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("32 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  39", mapa1[32], mapa1[33], mapa1[34], mapa1[35],mapa1[36], mapa1[37], mapa1[38], mapa1[39]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("40 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  47", mapa1[40], mapa1[41], mapa1[42], mapa1[43], mapa1[44], mapa1[45], mapa1[46], mapa1[47]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("48 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  55", mapa1[48], mapa1[49], mapa1[50], mapa1[51], mapa1[52], mapa1[53], mapa1[54], mapa1[55]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");
        Console.WriteLine("   |     |     |     |     |     |     |     |     |");
        Console.WriteLine("56 |  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  63", mapa1[56], mapa1[57], mapa1[58], mapa1[59], mapa1[60], mapa1[61], mapa1[62], mapa1[63]);
        Console.WriteLine("   |_____|_____|_____|_____|_____|_____|_____|_____|");

    }
    public void IniciarMapa(char[] mapa1)
    {
        for(int i = 0; i < mapa1.Length; i++) 
        {
            mapa1[i] = ' ';
        }

        mapa1[0] = 'N'; 
        mapa1[8] = 'A'; 
        mapa1[16] = 'V'; 
        mapa1[24] = 'I';
        mapa1[32] = 'O';
        mapa1[27] = 'N';
        mapa1[36] = 'A';
        mapa1[45] = 'V'; 
        mapa1[54] = 'I'; 
        mapa1[63] = 'O';
    }
       
}
