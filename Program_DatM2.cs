using System;
using System.IO;

namespace datotekaNakljucnihStevil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Na koliko mest naj bodo poravnana števila?");
            int poravnaj = int.Parse(Console.ReadLine());
            string ime = "datNakljucnihSt";
            int maxVrs = 10;
            int maxSt = 10;
            int maxVrednost = 99;
            Ustvari(ime, maxVrs, maxSt, maxVrednost, poravnaj);

            StreamReader branje = File.OpenText("datNakljucnihSt");
            int i = 0;
            string vrstica;
            while ((vrstica = branje.ReadLine()) != null)
            {
                Console.WriteLine(vrstica);
            }
            branje.Close();


        }

        public static void Ustvari(string ime, int maxvrstic, int maxstevil, int maxvrednost, int poravnaj = 0)
        {
            ///<summary>
            ///Funkcija prejme ime datoteke, št vrstic, št števil v vrstici, maksimalno vrednost števila
            ///in št mest na katera želimo poravnavati števila. Nato zgenerira datoteko, ki vsebuje ustrezno 
            ///število vrstic in stolpcev naključnih celih števil med 0 in podano maksimalno vrednostjo.
            /// </summary>
            StreamWriter pisanje = File.CreateText(ime);
            Random nakljucna = new Random();
            for (int i = 0; i < maxvrstic; i++)
            {
                for (int j = 0; j < maxstevil; j++)
                {
                    int st = nakljucna.Next(maxvrednost + 1);
                    int razlika = (st + "").Length; // določimo število presledkov ki jim moramo dodati
                    int koliko = poravnaj - razlika;
                    string niz = "";
                    for (int k = 0; k < koliko; k++)
                    {
                        niz += " ";
                    }
                    if (poravnaj == 0 || koliko <= 0) // pogoj || koliko <= 0 dodamo da so števila vedno ločena
                    {
                        niz = " ";
                    }
                    pisanje.Write(niz + st);
                }
                if (i != maxvrstic)
                {
                    pisanje.Write("\n");
                }
            }
            pisanje.Close();
        }
    }
}
