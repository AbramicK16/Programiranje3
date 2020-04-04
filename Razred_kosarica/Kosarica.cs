using System;
using System.Collections.Generic;
using System.Text;

namespace Razred_kosarica
{
    public class Kosarica<T>
    {
        private T objekt;

        //lastnost
        public T Podatek
        {
            get { return this.objekt; }
            set
            {
                this.objekt = value;
            }
        }

        //konstruktor
        public Kosarica(T podatek)
        {
            this.objekt = podatek;
        }


        public override string ToString()
        {
            return this.Podatek.ToString(); //Podatek iz lastnosti
        }
    }
}
