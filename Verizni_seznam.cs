using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Razred_VerizniSeznam
{
    class Verizni_seznam<T> : System.Collections.IEnumerable
    {
        
        private Vozel<T> prvi_vozel; //head
        private Vozel<T> zadnji_podatek;

        private int dolzina;

        public int Dolzina
        {
            get { return this.dolzina; }
            set { this.dolzina = value; }
        }
        /// <summary>
        /// Konstruktor brez spremenljivk, kjer sza zacetek in konec nastavljena na null
        /// </summary>
        public Verizni_seznam()
        {
            prvi_vozel = null;
            zadnji_podatek = null;
        }

        /// <summary>
        /// Metoda za dodat vozel na zacetek veriznega seznama
        /// </summary>
        /// <param name="podatek"></param>
        public void DodajNaZacetek(T podatek)
        {
            Vozel<T> novVozel = new Vozel<T>(podatek); //ustvarimo nov vozel
            novVozel.Naslednji = prvi_vozel;
            prvi_vozel = novVozel;
            dolzina++;
        }

        /// <summary>
        /// Odstranimo vozel z zacetka veriznega seznama.
        /// </summary>
        /// <returns></returns>
        public T OdstraniZZacetka()
        {
            if (prvi_vozel == null)
            {
                return default(T);//ce je seznam prazen vrnemo prazno
            }
            if (prvi_vozel.Naslednji == null)
            {//ce bo seznam po tem prazen je tudi zadnji podatek prazen
                zadnji_podatek = null;
            }
            T podatekPrvega = prvi_vozel.Podatek;
            prvi_vozel = prvi_vozel.Naslednji;
            dolzina--;
            return podatekPrvega;

        }

        /// <summary>
        /// Vozel dodamo na konec
        /// </summary>
        /// <param name="podatek"></param>
        public void DodajNaKonec(T podatek)
        {
            Vozel<T> novVozel = new Vozel<T>(podatek);
            if (zadnji_podatek == null)
            {
                prvi_vozel = zadnji_podatek;
                zadnji_podatek = novVozel;
                prvi_vozel = novVozel;
            }
            else
            {
                zadnji_podatek.Naslednji = novVozel;
                zadnji_podatek = novVozel;
            }
            dolzina++;
        }

        /// <summary>
        /// Odstranjujemo s konca
        /// </summary>
        /// <returns></returns>
        public T OdstraniSKonca()
        {
            Vozel<T> trenutni = prvi_vozel;//zacnemo na zacetku
            Vozel<T> trenutniPrejsnji = null;

            if (trenutni == null)
            {
                //ce je seznam prazen
                //return default(T);
                throw new Exception();
            }
            if (trenutni.Naslednji == null)
            {
                //ce je samo en na seznamu potem moramo seznam izprazniti
                prvi_vozel = null;
                zadnji_podatek = null;
                return default(T);
            }
            while (true)
            {
                if (trenutni.Naslednji == null)
                {
                    //ce smo prišli do konca
                    trenutniPrejsnji.Naslednji = null;
                    dolzina--;
                    return trenutni.Podatek;
                }
                trenutniPrejsnji = trenutni;//skocimo na naslednji element
                trenutni = trenutni.Naslednji;////skocimo na naslednji element
            }

        }

        public T VrednostNaMestu(int n)
        {
            if (n < 0 || n > dolzina)
            {
                //return default(T);
                throw new Exception();
            }
            Vozel<T> trenutni = prvi_vozel;
            int i = 0;
            while (true)
            {
                if (n == i)
                {
                    return trenutni.Podatek;
                }
                trenutni = trenutni.Naslednji;
                i++;
            }
        }

        public override string ToString()
        {
            string niz = "";
            Vozel<T> trenutni = prvi_vozel;
            while (trenutni.Naslednji != null)
            {
                niz += trenutni.Podatek.ToString();
                if (trenutni.Naslednji != null)
                {
                    niz += ", ";
                }
                trenutni = trenutni.Naslednji;
            }
            return niz + "]";
        }


        /// <summary>
        /// metoda vrne IEnumerator, ki foreach stavku pove kateri element je nasleden
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return new MojIEnumerator(this);
        }
        /// <summary>
        ///  metoda vrne IEnumerator, ki foreach stavku pove kateri element je nasleden
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MojIEnumerator(this);
        }

        private class MojIEnumerator : IEnumerator
        {
            private bool odZacetka = true;

            public MojIEnumerator(Verizni_seznam<T> collection)
            {
                _zbirka = collection;
                _trenutni = collection.prvi_vozel;
            }

            private Verizni_seznam<T> _zbirka;
            private Vozel<T> _trenutni;//kaj točno je T smo povedali, ko smo ustvarili Verizni_seznam

            public T Current
            {
                //to je trenutni element na katerega kaže kazalec in je tipa T
                get
                {
                    return _trenutni.Podatek;// vrne podatek trenutnega vozla
                }
            }
            object IEnumerator.Current => Current;//nanasajoc na zgornjo lastnost

            public void Dispose()
            {
                _trenutni = null;
                _zbirka = null;
            }

            public bool MoveNext()
            {
                //to se klice, ko foreach rabi naslednji podatek
                if (odZacetka)
                {
                    //ce je bil klican reset (pomeni, da zacne iterirati od zacetka)
                    odZacetka = false;//damo na false, da program normalno nadaljuje iteriranje
                    _trenutni = _zbirka.prvi_vozel;//ce je bilo resetirano potem zacnemo s prvim elementom
                }
                else
                {
                    _trenutni = _trenutni.Naslednji;
                }
                return _trenutni != null;//vrnemo true, ce smo se uspesno premaknili in false, ce smo na koncu seznama
            }

            public void Reset()
            {
                odZacetka = true;

            }
        }
        
    }
}
