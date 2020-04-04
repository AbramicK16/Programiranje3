using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Razred_kolo
{
    public class Kolo
    {
        private int stevilo_prestav;
        private string barva;
        private string tip; //gorsko, cestno, treking
        private int leto_izdelave;
        private int zaKolikoLjudi;

        public int PovejPrestave()
        {
            return this.stevilo_prestav;
        }

        //set metoda za prestave
        public void NastaviPrestave(int novaPrestava)
        {
            if ((novaPrestava <= 0) && (novaPrestava > 6)) throw new Exception("Nesmiselno število prestav");
            this.stevilo_prestav = novaPrestava;
        }

        //get metoda za barve
        public string PovejBarvo()
        {
            return this.barva;
        }

        //set metoda za barve
        public void NastaviBarvo(string barvaK)
        {
            this.barva = barvaK;
        }
        //get metoda za tip
        public string PovejTip()
        {
            return this.tip;
        }

        //set metoda za tip
        public void NastaviTip(string tipK)
        {
            if (tipK == "gorsko" | tipK == "cestno" | tipK == "treking") { this.tip = tipK; }
            else { throw new Exception("Tip kolesa je lahko samo gorsko, cestno ali treking."); }
        }
        //get metoda za koliko ljudi
        public int PovejStLjudi()
        {
            return this.zaKolikoLjudi;
        }

        //set metoda za koliko ljudi
        public void NastaviStLjudi(int stLjudi)
        {
            if (stLjudi <= 0) throw new Exception("Na kolesu ne more biti negativno stevilo ljudi ali enako 0");
            this.zaKolikoLjudi = stLjudi;
        }

        //get metoda za leto izdelave
        public int PovejLeto()
        {
            return this.leto_izdelave;
        }

        //set metoda za leto izdelave
        public void NastaviLeto(int letoK)
        {
            this.leto_izdelave = letoK;
        }

        /// <summary>
        /// Konstruktor kolesa
        /// </summary>
        /// <param name="stPrestav">stevilo prestav kolesa</param>
        /// <param name="barvaKolesa">barva kolesa</param>
        /// <param name="tipKolesa">tip kolesa</param>
        /// <param name="letoIzdelaveKolesa">kaksnega leta je bilo izdelano</param>
        /// <param name="stLjudi">za koliko ljudi je to kolo</param>
        public Kolo(int stPrestav, string barvaKolesa, string tipKolesa, int letoIzdelaveKolesa, int stLjudi)
        {
            if ((stPrestav <= 0) && (stPrestav > 6)) throw new Exception("Nesmiselno število prestav");
            this.stevilo_prestav = stPrestav;

            this.barva = barvaKolesa;

            if (tipKolesa == "gorsko" | tipKolesa == "cestno" | tipKolesa == "treking") { this.tip = tipKolesa; }
            else { throw new Exception("Tip kolesa je lahko samo gorsko, cestno ali treking."); }

            this.leto_izdelave = letoIzdelaveKolesa;

            if (stLjudi > 0) { this.zaKolikoLjudi = stLjudi; }
            else { throw new ArgumentException("Na kolesu se ne more voziti 0 ali negativno število ljudi."); }
        }


        /// <summary>
        /// Konstruktor podan kot niz
        /// </summary>
        /// <param name="opisKolesa">stevilo_prestav,barva,tip,leto_izdelave,zaKolikoLjudi</param>
        public Kolo(string opisKolesa)
        {
            string[] tabela = opisKolesa.Split(','); //opis kolesa glede na , razbijem na več delov in jih shranim v tabelo nizov

            int prestave = int.Parse(tabela[0]); //niz pretvorim v stevilo
            if ((prestave <= 0) && (prestave > 6)) throw new Exception("Nesmiselno število prestav");
            this.stevilo_prestav = prestave;

            this.barva = tabela[1];

            string tip = tabela[2];
            if (tip == "gorsko" | tip == "cestno" | tip == "treking") { this.tip = tip; }
            else { throw new Exception("Tip kolesa je lahko samo gorsko, cestno ali treking."); }

            this.leto_izdelave = int.Parse(tabela[3]);

            int stLjudi = int.Parse(tabela[4]);
            if (stLjudi <= 0) throw new Exception("Na kolesu ne more biti negativno stevilo ljudi ali enako 0");
            this.zaKolikoLjudi = stLjudi;
        }
        /// <summary>
        /// Metoda za izpis
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Število prestav: " + this.stevilo_prestav + "; Barva: " + this.barva + "; Tip: " + this.tip + "; Leto izdelave: " + this.leto_izdelave + "; Število ljudi:  " + this.zaKolikoLjudi;
        }

        /// <summary>
        /// Podatke o kolesu zapise na datoteko z imenom moja_dat.
        /// </summary>
        /// <param name="moja_dat"></param>
        /// <param name="kolo"></param>
        public static void DodajNaDatoteko(string moja_dat, Kolo kolo)
        {
            if (File.Exists(moja_dat)) //ce datoteka ze obstaja
            {
                using (StreamWriter pisanje = File.CreateText(moja_dat))
                {
                    pisanje.WriteLine(kolo.ToString());
                }
            }
            else //(File.Exists(moja_dat)) ce datoteka se ne obstaja, ustvarimo datoteko za pisanje
            {
                using (StreamWriter pisanje = File.CreateText(moja_dat))
                {
                    pisanje.WriteLine(kolo.ToString());
                }
            }
        }

        /// <summary>
        /// Iz datoteke z imenom moja_dat prebere zeljeno vrstico in izpise podatke o kolesu.
        /// </summary>
        /// <param name="moja_dat"></param>
        /// <param name="vrstica"></param>
        /// <returns></returns>

        public static Kolo UstvariIzDatoteke(string moja_dat, int vrstica)
        {
            //ce datoteka ne obstaja, vrnemo napako
            if (!File.Exists(moja_dat)) throw new Exception("Ta datoteka ne obstaja!");

            string zeljena_vrstica = "";

            using (StreamReader branje = new StreamReader(moja_dat))
            
                for (int i = 1; i <= vrstica; i++)
                {
                    zeljena_vrstica = branje.ReadLine();

                    //ce ni dovolj vrstic v datoteki, vrnemo napako
                    if (zeljena_vrstica == null) throw new Exception("V datoteki ni toliko vrstic!");
                }
            string[] podatek = zeljena_vrstica.Split(';');
            Kolo kolo = new Kolo(int.Parse(podatek[0]), podatek[1], podatek[2], int.Parse(podatek[3]), int.Parse(podatek[4]));
            return kolo;            
        }

        /// <summary>
        /// Iz datoteke prebere podatke in vrne tabelo koles. 
        /// </summary>
        /// <param name="moja_dat"></param>
        /// <returns></returns>
        public Kolo[] TabelaIzDatoteke(string moja_dat)
        {
            //ce datoteka ne obstaja, vrnemo napako
            if (!File.Exists(moja_dat)) throw new Exception("Ta datoteka ne obstaja!");

            int vrstice = File.ReadLines(moja_dat).Count(); //vrstic je toliko koliko je koles
            Kolo[] tabelaKoles = new Kolo[vrstice];
            using (StreamReader branje = new StreamReader(moja_dat))
                for (int i = 1; i <= vrstice; i++)
                {
                    tabelaKoles[i - 1] = UstvariIzDatoteke(moja_dat, i);
                }
            return tabelaKoles;
        }


        /// <summary>
        /// Metoda vrne stevilo, ki predstavlja stevilo koles barve barva v dani tabeli koles
        /// </summary>
        /// <param name="tabela">tabela koles</param>
        /// <param name="barva"></param>
        /// <returns></returns>
        public int prestejBarveKoles(Kolo[] tabela, string barva)
        {
            int stevec = 0;
            for (int i = 0; i < tabela.Length; i++) //pregledamo celotno tabelo Koles
            {
                if (tabela[i].PovejBarvo() == barva) //ce barva ustreza podani barvi, povecamo stevec
                {
                    stevec++;
                }
            }
            return stevec;
        }

        
        /// <summary>
        /// Metoda, ki prebarva vsa rumena kolesa v rdeca v dani tabeli koles.
        /// </summary>
        /// <param name="tabela">tabela koles</param>
        public void prebarvaj(Kolo[] tabela)
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i].PovejBarvo() == "rumena") //ko naletimo na kolo rumene barv
                {
                    tabela[i].NastaviBarvo("rdeca"); //ga prebarvamo v rdeco
                }
            }
        }

        /// <summary>
        /// Metoda, ki pove koliko ljudi se lahko hkrati pelje s cestnimi kolesi
        /// </summary>
        /// <param name="tabela"></param>
        /// <returns></returns>
        public int KolikoSCestnimiKolesi(Kolo[] tabela)
        {
            int stevec = 0;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i].PovejTip() == "cestno") //ce je kolo cestno, povecamo stevec
                {
                    stevec += tabela[i].PovejStLjudi();
                }
            }
            return stevec;
        }

        /// <summary>
        /// Naključna tabela 100 koles
        /// </summary>
        /// <returns></returns>
        public Kolo[] GenerirajTabeloKoles()
        {
            string[] izbiraPrestav = { "1", "2", "3", "4", "5", "6" };
            string[] izbiraBarv = { "bela", "crna", "rdeca", "rumena", "modra", "vijola", "zelena", "oranzna", "siva", "roza", "rjava" };
            string[] izbiraTipa = { "gorsko", "cestno", "treking" };
            string[] izbiraLetaIzdelave = { "2000", "2001", "2003", "2005", "2009", "2010" };
            string[] izbiraStLjudi = { "1", "2", "3" };

            Kolo[] tabelaKoles = new Kolo[100];

            Random genPrestave = new Random();
            Random genBarve = new Random();
            Random genTip = new Random();
            Random genLetoIzdelave = new Random();
            Random genStLjudi = new Random();

            for (int i = 0; i < tabelaKoles.Length; i++)
            {
                int prestave = genPrestave.Next(0, 6); //generiram naključno stevilo
                int barva = genBarve.Next(0, 11);
                int tip = genTip.Next(0, 3);
                int leto_izdelave = genLetoIzdelave.Next(0, 6);
                int stLjudi = genStLjudi.Next(0, 3);
                
                tabelaKoles[i] = new Kolo(int.Parse(izbiraPrestav[prestave]), izbiraBarv[barva], izbiraTipa[tip], int.Parse(izbiraLetaIzdelave[leto_izdelave]), int.Parse(izbiraStLjudi[stLjudi]));
            }
            return tabelaKoles;
        }
    }
}
