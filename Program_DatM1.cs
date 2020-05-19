using System;
using System.IO;

namespace toJeMojaDatoteka
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = "";
            while (true)
            {
                try
                {
                    Console.WriteLine("Vnesi ime datoteke: ");
                    string niz = Console.ReadLine();
                    f = niz;
                    //preverimo ali datoteka že obstaja
                    StreamReader dat = File.OpenText(niz);
                    dat.Close();
                    //če datoteka že obstaja še enkrat vprašamo po imenu
                }
                catch
                {
                    // če datoteke s tem imenom še ni, lahko nadaljujemo
                    break;
                }
            }

            //ustvarimo datoteko
            StreamWriter pisanje = File.CreateText(f);
            pisanje.WriteLine("To je moja datoteka");
            pisanje.Close();

            //izpišemo prvo vrstico v datoteki
            StreamReader branje = File.OpenText(f);
            string vrstica = branje.ReadLine();
            Console.WriteLine(vrstica);
            branje.Close();

            //v datoteko na konec dodamo eno vrstico
            StreamWriter dodajanje = File.AppendText(f);
            Console.WriteLine("Vnesi ime: ");
            string ime = Console.ReadLine();
            dodajanje.WriteLine(ime);
            dodajanje.Close();

            //datoteko preberemo in izpišemo vrstice
            StreamReader novobranje = File.OpenText(f);
            int i = 0;
            while ((vrstica = novobranje.ReadLine()) != null)
            {
                Console.WriteLine(++i + ": " + vrstica);
            }
            novobranje.Close();
        }
    }
}
