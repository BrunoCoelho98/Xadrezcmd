using System;
using System.Security.Cryptography.X509Certificates;
using tabuleiro;

namespace jogodexadrez
{
    internal class Torre : Peca
    {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}