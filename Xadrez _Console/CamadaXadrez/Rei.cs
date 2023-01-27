using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez__Console.Tabuleiro;

namespace Xadrez__Console.CamadaXadrez
{
    internal class Rei : Pecas
    {
        public Rei(Cor cor,TabuleiroJogo tab) : base(cor,tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }

    }
}
