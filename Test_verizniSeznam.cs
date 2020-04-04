using System;
using System.Collections.Generic;

namespace Razred_VerizniSeznam
{
    class Test_verizniSeznam
    {
        static void Main(string[] args)
        {
            Verizni_seznam<int> mojSeznam = new Verizni_seznam<int>();

            mojSeznam.DodajNaKonec(4);
            mojSeznam.DodajNaKonec(2);
            mojSeznam.DodajNaKonec(11);
            mojSeznam.DodajNaKonec(7);

            Console.WriteLine("Verizni seznam je: ");

            foreach(int i in mojSeznam)
            {
                Console.WriteLine(i);
            }

            mojSeznam.DodajNaZacetek(1);
            Console.WriteLine("Stevilo vozlov seznamu je: " + mojSeznam.Dolzina);
             
            foreach (int i in mojSeznam)
            {
                Console.WriteLine(i);
            }

            mojSeznam.DodajNaKonec(100);
            Console.WriteLine("Stevilo vozlov seznamu je: " + mojSeznam.Dolzina);

            foreach (int i in mojSeznam)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Odstranimo prvi vozel.");
            mojSeznam.OdstraniZZacetka();
            foreach (int i in mojSeznam)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Odstranimo prvi vozel.");
            mojSeznam.OdstraniZZacetka();
            foreach (int i in mojSeznam)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Odstranimo zadnji vozel.");
            Console.WriteLine("Dolzina seznama je: " + mojSeznam.Dolzina);

            mojSeznam.OdstraniSKonca();
            foreach (int i in mojSeznam)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Vozel na mestu 2 v seznamu ima vrednost: " + mojSeznam.VrednostNaMestu(2));

        }
    }
}
