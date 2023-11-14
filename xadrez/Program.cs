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
                    try
                    {
                        Console.Clear();
                        Tela.imprimirtabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.Write("Turno: " + partida.turno);
                        Console.WriteLine();
                        Console.WriteLine("Aguardadno jogada: " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirtabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

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
