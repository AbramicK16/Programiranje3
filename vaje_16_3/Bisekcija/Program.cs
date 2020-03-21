using System;

namespace Bisekcija
{
    class Program
    {
        static void Main(string[] args)
        {
            int podatek = int.Parse(Console.ReadLine());

            int[] tab1 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] tab2 = new int[] { 11, 21, 34, 44, 51, 67, 68, 100, 105 };
            int[] tab3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Bisekcija(tab1, podatek);
            Bisekcija(tab2, podatek);
            Bisekcija(tab3, podatek);
        }

        public static int Bisekcija<T>(T[] tabela, T podatek) where T : IComparable<T>
            // primerjali bomo le objekte tipa T z drugih objektom istega tipa
        {
            int zacetek = 0; //dolocimo zacetek tabele
            int konec = tabela.Length - 1; //konec tabele
            int polovica = konec / 2; //srednji element v tabeli

            while (konec - zacetek >= 0)
            {
                if (podatek.CompareTo(tabela[polovica]) == 0) //podatek je na sredini
                {
                    Console.WriteLine("Podatek je vsebovan v tabeli."); //podatek je element tabele
                    return 0;  // podatek je najden
                }

                if (podatek.CompareTo(tabela[polovica]) < 0)
                {
                    konec = polovica - 1; // pregledujemo na prvi polovici

                }

                else
                {
                    zacetek = polovica + 1; // pregledamo od druge polovice do konca
                }
                polovica = (zacetek + konec) / 2; // določimo novo polovico
                
            }
            Console.WriteLine("Podatka ni v tabeli."); //podatka zagotovo ni v tabeli
            return -1; //elementa ni v tabeli

        }

        
    }
}