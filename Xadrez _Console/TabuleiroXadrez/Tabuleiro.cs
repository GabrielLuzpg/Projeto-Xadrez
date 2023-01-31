using System;
using System.Collections.Generic;
using Xadrez__Console.TabuleiroXadrez;

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

        public Pecas Peca(int linha, int coluna)
        {
            return PecasTabuleiro[linha, coluna];
        }
        public Pecas Peca(Posicao posicao)
        {
            return PecasTabuleiro[posicao.LinhasPosicao, posicao.ColunasPosicao];
        }



        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return Peca(posicao) != null;
        }


        public void ColocarPeca(Pecas p, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroExeception("Já existe uma peça nessa posição! ");
            }
            PecasTabuleiro[posicao.LinhasPosicao, posicao.ColunasPosicao] = p;
            p.Posicao = posicao;
        }


        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.LinhasPosicao < 0 || posicao.LinhasPosicao >= LinhasTabuleiro || posicao.ColunasPosicao < 0 || posicao.ColunasPosicao >= ColunasTabuleiro)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroXadrez.TabuleiroExeception("Posição inválida");
            }
        }
    }
}
