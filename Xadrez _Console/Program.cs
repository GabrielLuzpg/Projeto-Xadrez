using System;
using Xadrez__Console;
using Xadrez__Console.Tabuleiro;
using Xadrez__Console.CamadaXadrez;

namespace Xadrez_Console
{
    class program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());
            
        }
    }
}