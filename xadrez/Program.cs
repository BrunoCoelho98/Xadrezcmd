﻿using System;
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

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

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
                        partida.validarPosicaoDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }
                Console.Clear();
                Tela.imprimirPartida(partida);

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
