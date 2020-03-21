using System;

namespace Izpis_Tabele
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabela1 = new int[] { 12, 5, 6, 78, 3, 5, 6, 21, 434, 56, 42, 7 };
            string[] tabNizov = new string[] { "modra", "siva", "rumena", "rdeca", "zelena", "bela", "crna", "roza" };
            int n = 5;
            int m = 2;
            string vmes = " : ";
            string med = " - ";
            IzpisTabele(tabela1, n, vmes);
            IzpisTabele(tabNizov, m, med);
        }
        public static void IzpisTabele<T>(T[] tabela, int n, string vmes)
        // primerjali bomo le objekte tipa T z drugih objektom istega tipa
        {
            for (int i = 0; i < tabela.Length;)
            {
                for (int k = 0; k < n; k++)
                {
                    if (i < tabela.Length)
                    {
                        Console.Write(tabela[i] + vmes);
                        i++;
                    }
                    
                }
                Console.WriteLine();
            }

        }
        
    }
}
