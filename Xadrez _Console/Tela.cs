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
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.ColunasTabuleiro; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    } else
                    {
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirPeca(Pecas peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            } else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }

}
