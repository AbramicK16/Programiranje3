using System;
using System.Collections.Generic;
using System.Text;

namespace Razred_Kompleksno_Stevilo
{
    public class Kompleksno_stevilo
    {
        private double Re;
        private double Im;

        public double Realni_del
        {
            get { return this.Re; }
            set { this.Re = value; }
        }

        public double Imaginarni_del
        {
            get { return this.Im; }
            set { this.Im = value; }
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="realno_st">Realni del stevila</param>
        /// <param name="imag_st">Imaginarni del stevila</param>
        public Kompleksno_stevilo(double realno_st, double imag_st)
        {
            this.Re = realno_st;
            this.Im = imag_st;
        }

        /// <summary>
        /// Lastnost za absolutno vrednost kompleksnega st
        /// </summary>
        public double R
        {
            get { return Math.Pow ((Math.Pow (this.Re, 2) + Math.Pow (this.Im, 2)), 0.5); }
            //set
        }

        /// <summary>
        /// Lastnost za argument kompleksnega st
        /// </summary>
        public double Arg 
        {
            get { return Math.Atan2 (Im, Re); }
            set
            {
                if (value == 0) throw new Exception ("Z nič se ne da deliti");                
            }
        }

        public override string ToString()
        {
            string niz = this.Re.ToString () + " " + this.Im.ToString () + "i";
            if (Re == 0) niz = this.Im.ToString ();
            if (Im == 0) niz = this.Re.ToString ();

            if (Im == 1) niz = this.Re.ToString() +  " i";
            if (Im == -1) niz = this.Re.ToString () + " - i";

            if (Im < 0) niz = this.Re.ToString () + " " + this.Im.ToString () + "i";
            return niz;           
        }

        public static Kompleksno_stevilo operator +(Kompleksno_stevilo z, Kompleksno_stevilo u)
        {
            double real = z.Re + u.Re;
            double imag = z.Im + u.Im;
            return new Kompleksno_stevilo(real, imag);
        }

    }
}
