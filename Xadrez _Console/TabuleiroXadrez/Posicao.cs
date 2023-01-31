using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez__Console.Tabuleiro
{
    internal class Posicao
    {

        public int LinhasPosicao { get; set; }
        public int ColunasPosicao { get; set; }

        public Posicao(int linhas, int colunas)
        {
            LinhasPosicao = linhas;
            ColunasPosicao = colunas;
        }


        public override string ToString()
        {
            return "" + LinhasPosicao +". " + ColunasPosicao;
        }

    }
}
