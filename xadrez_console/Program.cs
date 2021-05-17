using System;
using tabuleiro;
using tabuleiro.Enum;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro t = new Tabuleiro(8,8);
            Console.WriteLine(t);
            
        }


    }
}
