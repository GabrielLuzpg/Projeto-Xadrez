using System;
using Xadrez__Console.Tabuleiro;

namespace Xadrez__Console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroJogo tab)
        {
            for (int i = 0; i < tab.LinhasTabuleiro; i++)
            {
                for (int j = 0; j < tab.ColunasTabuleiro; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    } else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
