using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Models
{
    public class TabuleiroView
    {
        List<char>abatidas= new List<char>();
        public void RealizarJogadas(char[] t)
        {
            char aux =' ';
            
            Console.Write("Origem: ");
            int origem = int.Parse(Console.ReadLine());

            Console.Write("Destino: ");
            int destino = int.Parse(Console.ReadLine());
            if (t[destino] == 0)
            {
                aux = t[destino];
                t[destino] = t[origem];
                t[origem] = aux;
            }
            else
            { 
                t[destino] = t[origem];
                t[origem] = ' ';
                abatidas.Add(aux);
            }
        }
        public void MostrarTabuleiro(char[]t)
        {
            Console.Clear();
                        
            Console.WriteLine(" _______________________________________________");
            Console.WriteLine("|     |     |     |     |     |     |     |     |");
            Console.WriteLine("| {0}   | {1}   | {2}   | {3}   | {4}   | {5}   | {6}   | {7}   | 0 - 7", t[0], t[1], t[2], t[3], t[4], t[5], t[6], t[7]) ;
            Console.WriteLine("|_____|_____|_____|_____|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |");
            Console.WriteLine("| {0}   | {1}   | {2}   | {3}   | {4}   | {5}   | {6}   | {7}   | 8 - 15", t[8], t[9], t[10], t[11], t[12], t[13], t[14], t[15]) ;
            Console.WriteLine("|_____|_____|_____|_____|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |");
            Console.WriteLine("| {0}   | {1}   | {2}   | {3}   | {4}   | {5}   | {6}   | {7}   | 15 - 23", t[16], t[17], t[18], t[19], t[20], t[21], t[22], t[23]) ;
            Console.WriteLine("|_____|_____|_____|_____|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |");
            Console.WriteLine("| {0}   | {1}   | {2}   | {3}   | {4}   | {5}   | {6}   | {7}   | 24 - 31", t[24], t[25], t[26], t[27], t[28], t[29], t[30], t[31]) ;
            Console.WriteLine("|_____|_____|_____|_____|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |");
            Console.WriteLine("| {0}   | {1}   | {2}   | {3}   | {4}   | {5}   | {6}   | {7}   | 32 - 39", t[32], t[33], t[34], t[35], t[36], t[37], t[38], t[39]) ;
            Console.WriteLine("|_____|_____|_____|_____|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |");
            Console.WriteLine("| {0}   | {1}   | {2}   | {3}   | {4}   | {5}   | {6}   | {7}   | 40 - 47", t[40], t[41], t[42], t[43], t[44], t[45], t[46], t[47]) ;
            Console.WriteLine("|_____|_____|_____|_____|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |"); 
            Console.WriteLine("| {0}   | {1}   | {2}   | {3}   | {4}   | {5}   | {6}   | {7}   | 48 - 55", t[48], t[49], t[50], t[51], t[52], t[53], t[54], t[55]) ;
            Console.WriteLine("|_____|_____|_____|_____|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |");
            Console.WriteLine("| {0}   | {1}   | {2}   | {3}   | {4}   | {5}   | {6}   | {7}   | 56 - 63", t[56], t[57], t[58], t[59], t[60], t[61], t[62], t[63]) ;
            Console.WriteLine("|_____|_____|_____|_____|_____|_____|_____|_____|");
            
        }
        public void IniciarTabuleiro(char[] t)
        {
            t[0] = 'T'; t[8]= 'P'; 
            t[1] = 'C'; t[9] = 'P';
            t[2] = 'B'; t[10] = 'P';
            t[3] = 'R'; t[11] = 'P';
            t[4] = 'D'; t[12] = 'P';
            t[5] = 'B'; t[13] = 'P';
            t[6] = 'C'; t[14] = 'P';
            t[7] = 'T'; t[15] = 'P';

            

            t[56] = 't'; t[48] = 'p';
            t[57]= 'c'; t[49] = 'p';
            t[58]= 'b'; t[50] = 'p';
            t[59] = 'r'; t[51] = 'p';
            t[60] = 'd'; t[52] = 'p';
            t[61] = 'b'; t[53] = 'p';
            t[62] = 'c'; t[54] = 'p';
            t[63] = 't'; t[55] = 'p';
        }

    }
}









