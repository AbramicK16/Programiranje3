using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Razred_registracija
{
    class Registracija
    {
        private string[] obmocja = new string[] { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };
        private string registracija;
        private string obmocje;

        public string Registrska_st
        {
            get { return this.registracija; }
            set
            {
                if (value.Length == 5) { this.registracija = value; }
                throw new Exception("Registracija mora biti sestavljena iz pet alfanumeričnih znakov.");
            }
        }

        public string Obmocje
        {
            get { return this.obmocje; }
            set
            {
                if (!obmocje.Contains(value)) throw new Exception("To obmocje je neveljavno!");
                else { this.obmocje = value; }
            }
        }

        public string[] Tabela_Obmocja
        {
            get { return this.obmocja; }
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="obmocjeR"></param>
        /// <param name="registrR"></param>
        public Registracija(string obmocjeR, string registrR)
        {
            this.obmocje = obmocjeR;
            this.registracija = registrR;
        }

        public override string ToString()
        {
            return this.obmocje + " " + this.registracija;
        }

        /// <summary>
        /// V tabelo obmocij doda novo obmocje.
        /// </summary>
        /// <param name="obm">Obmocje, ki ga dodamo</param>
        public void DodamoNovo(string obm)
        {
            if (!this.obmocja.Contains(obm))
            {
                string[] tabela_obmocij = new string[this.obmocja.Length + 1];
                for (int i = 0; i < this.obmocja.Length; i++)
                {
                    tabela_obmocij[i] = this.obmocja[i];
                }
                tabela_obmocij[this.obmocja.Length] = obm;
                this.obmocja = tabela_obmocij;
            }
        }

        /// <summary>
        /// S tabele območij odstranimo območje obm.
        /// Ce tega obmocja ni v tabeli, vrnemo napako
        /// </summary>
        /// <param name="obm"></param>
        public void Odstrani(string obm)
        {
            if (!this.obmocja.Contains(obm)) throw new Exception("Tega obmocja ni v tabeli. ");

            if (this.obmocja.Contains(obm))
            {
                string[] tabela_obmocij = new string[this.obmocja.Length - 1];
                int ind = 0;
                foreach (string niz in this.obmocja) //gremo po vseh elementiv v tabeli obmocja
                {
                    if (niz != obm) // "skopiramo" elemente, ki niso enali tistemu, ki ga želimo odstraniti
                    {
                        tabela_obmocij[ind] = this.obmocja[ind];
                        ind++;
                    }
                }
                this.obmocja = tabela_obmocij;
            }

        }
    }
}
