using System;
using tabuleiro;
using tabuleiro.Enum;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(32,32);
            Tela.ImprimirTabuleiro(tab);
            Console.WriteLine(tab);
            
        }


    }
}
