using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Models
{
    public class Jogador
    {
		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

        public Jogador(string nomeJogador)
        {
            this.nome = nomeJogador;
        }
    }
}
