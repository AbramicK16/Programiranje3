using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Razred_kolo
{
    class Test_kolo
    {
        static void Main(string[] args)
        {
            Kolo mojeKolo = new Kolo(5, "modra", "gorsko", 2005, 1); //ustvarim novo kolo

            //tabela 100tih koles
            string[] barve = new string[] { "bela", "crna", "rdeca", "rumena", "modra", "vijola", "zelena", "oranzna", "siva", "roza", "rjava" };
            string[] tipi = new string[] { "gorsko", "cestno", "treking" };
            Kolo[] tabela = new Kolo[100];
            Random random = new Random();
            for (int i = 0; i < tabela.Length; i++)
            {
                Kolo kolo = new Kolo(random.Next(1, 6), barve[random.Next(0, barve.Length)], tipi[random.Next(0, tipi.Length)], random.Next(1950, DateTime.Now.Year + 1), random.Next(1, 11));
                tabela[i] = kolo;
            }


            Console.WriteLine();

            Console.WriteLine();
            int prestava = tabela[24].PovejPrestave();
            Console.WriteLine("Petindvajseto kolo v tabeli ima prestave: " + prestava + ".");

            string barva = tabela[28].PovejBarvo();
            Console.WriteLine("Barva devetindvajsetega kolesa v tabeli je: " + barva + ".");

            string tip = tabela[99].PovejTip();
            Console.WriteLine("Stoto kolo v tabeli je tipa: " + tip + ".");

            int leto = tabela[10].PovejPrestave();
            Console.WriteLine("Enajsto kolo v tabeli je bilo izdelano leta: " + leto + ".");

            int kolikoLjudi = tabela[51].PovejPrestave();
            Console.WriteLine("Dvainpetdeseto kolo v tabeli je predpisamo za " + kolikoLjudi + "ljudi.");

            Console.WriteLine();

            Console.WriteLine();
            tabela[9].NastaviBarvo("roza");
            tabela[9].NastaviPrestave(4);
            tabela[9].NastaviLeto(2018);
            tabela[9].NastaviStLjudi(3);
            tabela[9].NastaviTip("cestno");
            Console.WriteLine("Deseto kolo v tabeli koles mora biti cestno kolo roza barve izdelano leta 2018. Primerno je za 3 ljudi in ima 4 prestave.");

            Console.WriteLine();
            for (int i = 0; i < tabela.Length; i++)
            {
                Console.WriteLine(tabela[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine();

            //koliko koles je dolocene barve
            int modraKolesa = mojeKolo.prestejBarveKoles(tabela, "modra");
            Console.WriteLine("Stevilo modrih koles v tabeli je: " + modraKolesa);

            int sivaKolesa = mojeKolo.prestejBarveKoles(tabela, "siva");
            Console.WriteLine("Stevilo sivih koles v tabeli je: " + sivaKolesa);

            int zlataKolesa = mojeKolo.prestejBarveKoles(tabela, "zlata");
            Console.WriteLine("Stevilo zlatih koles v tabeli je: " + zlataKolesa);

            //koliko ljudi se lahko hkrati vozi s cestnimi kolesi
            int koliko = mojeKolo.KolikoSCestnimiKolesi(tabela);
            Console.WriteLine("Hkrati se s cestnimi kolesi lahko vozi " + koliko + "ljudi");

            //prebarvamo kolo - metoda vraca samo ucinek
            mojeKolo.prebarvaj(tabela);

            Console.WriteLine();
            Console.WriteLine("Rumena kolesa smo prebarvali v rdeca. ");
            for (int i = 0; i < tabela.Length; i++)
            {
                Console.WriteLine(tabela[i]);
            }
            Console.WriteLine(" ");
            Console.ReadLine();

            
            foreach (Kolo kolo in tabela) { Kolo.DodajNaDatoteko("dat_koles", kolo); }; //podatke napisemo na dat

            Console.WriteLine();
            Console.WriteLine("Ali dobimo kolo?");
            Kolo k = Kolo.UstvariIzDatoteke("C: \\Users\\katar\\OneDrive\\Dokumenti\\Programiranje3\\Vaje_30_3\\Razred_kolo\\dat_koles", 3);
            Console.WriteLine(k.ToString());
            Console.WriteLine();


            Odstrani("C: \\Users\\katar\\OneDrive\\Dokumenti\\Programiranje3\\Vaje_30_3\\Razred_kolo\\dat_koles");
            Izdelava("C: \\Users\\katar\\OneDrive\\Dokumenti\\Programiranje3\\Vaje_30_3\\Razred_kolo\\dat_koles");
        }

        public static void Odstrani(string moja_dat)
        {
            //ce datoteka ne obstaja, sprozimo napako
            if (!File.Exists(moja_dat)) { throw new ArgumentNullException("Ta datoteka ne obstaja."); }

            int leto = DateTime.Now.Year - 12; //dolocimo kolesa, ki jih obdrzimo
            var obdrzi = File.ReadLines(moja_dat).Where(line => (leto <= int.Parse(line.Split(',')[0])));

            string nova_dat = Path.GetTempFileName();
            File.WriteAllLines(nova_dat, obdrzi);

            File.Delete(moja_dat);
            File.Move(nova_dat, moja_dat);
        }
  
        public static void Izdelava(string moja_dat)
        {
            if (!File.Exists(moja_dat)) { throw new ArgumentNullException("Ta datoteka ne obstaja."); }

            string zacasna_vrstica = ""; //željena vrstica

            using (StreamReader branje = new StreamReader(moja_dat))
            {

                int vrst = File.ReadLines(moja_dat).Count();
                for (int i = 0; i < vrst; i++)
                {
                    zacasna_vrstica = branje.ReadLine(); //preberemo vrstico
                    string leto = zacasna_vrstica.Split(',')[0];//leto idelave kolesa
                    string ime_po_letih = "Kolesa" + leto;

                    if (!File.Exists(ime_po_letih))
                    {
                        //ce datoteka se ne obstaja, jo ustvarimo
                        using (StreamWriter pisanje = File.CreateText(ime_po_letih))
                        {
                            pisanje.WriteLine(zacasna_vrstica);
                        }
                    }

                    using (StreamWriter pisanje = File.AppendText(ime_po_letih)) //na dat dodamo kolo
                    {
                        pisanje.WriteLine(zacasna_vrstica);
                    }
                }
            }
        }
    }
}
