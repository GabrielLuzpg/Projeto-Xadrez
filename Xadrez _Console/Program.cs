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
            try
            {
                TabuleiroJogo tab = new TabuleiroJogo(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(2, 4));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(3, 5));


                Tela.ImprimirTabuleiro(tab);






            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);            
            
            
            }
            
        }
    }
}