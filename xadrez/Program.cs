using System;
using tabuleiro;
using xadrez;
using jogodexadrez;

namespace xadez
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('a',1);
            /*
            Tabuleiro tab = new Tabuleiro(8, 8);


            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.imprimirtabuleiro(tab);
            */

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
           
            Console.ReadLine();
        }
    }
}
