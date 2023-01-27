using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez__Console.Tabuleiro
{
    internal class TabuleiroJogo
    {

        public int LinhasTabuleiro { get; set; }
        public int ColunasTabuleiro { get; set; }

        private Pecas[,] PecasTabuleiro;

        public TabuleiroJogo(int linhas, int colunas)
        {
            LinhasTabuleiro = linhas;
            ColunasTabuleiro = colunas;
            PecasTabuleiro = new Pecas[LinhasTabuleiro, ColunasTabuleiro];

        }

        public Pecas Peca (int linha, int coluna)
        {
            return PecasTabuleiro[linha, coluna];
        }
    }
}
