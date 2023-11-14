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

            // PosicaoXadrez pos = new PosicaoXadrez('a',1);
            try
            {
                PartidadeXadrez partida = new PartidadeXadrez();

                Tela.imprimirtabuleiro(partida.tab);
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirtabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);

                }


                

            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            

            //Console.WriteLine(pos);
            //Console.WriteLine(pos.toPosicao());
           
            Console.ReadLine();
        }
    }
}
