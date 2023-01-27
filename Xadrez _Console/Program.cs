using System;
using Xadrez__Console;
using Xadrez__Console.Tabuleiro;

namespace Xadrez_Console
{
    class program
    {
        static void Main(string[] args)
        {

            TabuleiroJogo tab = new TabuleiroJogo(8,8);

            Tela.ImprimirTabuleiro(tab);





        }
    }
}