using System;
using System.Collections.Generic;
using System.Text;

namespace Razred_VerizniSeznam
{
    public class Vozel<T>
    {
        private T podatek;
        private Vozel<T> naslednji;

        //lastnosti za podatek
        public T Podatek
        {
            get { return this.podatek; }
            set { this.podatek = value; }
        }

        //lastnosti za vozel

        public Vozel<T> Naslednji
        {
            get { return this.naslednji; }
            set { this.naslednji = value; }
        }
           
        /// <summary>
        /// Konstruktor za vozel
        /// </summary>
        /// <param name="vrednost"></param>
        public Vozel(T vrednost)
        {
            this.podatek = vrednost;
            this.naslednji = null;
        }

        /*public static void izpisVozla(Vozel<T> prvi_podatek)
        {
            Vozel<T> trenutni_vozel = prvi_podatek;
            while (trenutni_vozel != null)
            {
                Console.WriteLine(trenutni_vozel.prvi_podatek);
                trenutni_vozel = trenutni_vozel.prvi_podatek;
            }
        }*/


    }
}
