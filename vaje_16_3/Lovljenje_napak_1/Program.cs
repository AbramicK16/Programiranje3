using System;

namespace Lovljenje_napak_1
{
    class Program
    {
        public static int[] Tabeliraj(int velikost)
        {
            int[] mojaTabela = new int[velikost]; //tabela velikosti velikost
            for (int i = 0; i < velikost; i++)
            {
                try
                {
                    mojaTabela[i] = F(i);
                }
                catch
                {
                    mojaTabela[i] = 0;
                }
            }
            return mojaTabela;
        }

        public static int F(int i)
        {
            return 100 / (i % 3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
