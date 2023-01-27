using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez__Console.Tabuleiro
{
    internal class Tabuleiro
    {

        public int LinhasTabuleiro { get; set; }
        public int ColunasTabuleiro { get; set; }

        private Peca[,] PecasTabuleiro;

        public Tabuleiro(int linhas, int colunas)
        {
            LinhasTabuleiro = linhas;
            ColunasTabuleiro = colunas;
            PecasTabuleiro = new Peca[LinhasTabuleiro, ColunasTabuleiro];

        }
    }
}
