using System;
using System.Linq;
namespace Razred_registracija
{
    class Test_registracija
    {
        static void Main(string[] args)
        {
            string[] obmocja = new string[] { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };
            Random random = new Random();
            Registracija[] tabelaRegistracij = new Registracija[100];
            for (int el = 0; el < 100; el++)
            {
                string obmocje = obmocja[random.Next(11)];
                string registracija = RandomString(5);
                tabelaRegistracij[el] = new Registracija(obmocje, registracija);

                /*for (int st = 1; st <=100; st++)
                {
                    Console.WriteLine("Izpis vseh registrskih tablic: " + st + " : " + tabelaRegistracij[el]);
                }*/
                Console.WriteLine("Izpis vseh registrskih tablic: " + tabelaRegistracij[el]);
            }

            Console.WriteLine();
            Console.WriteLine("Registrske tablice iz danega obmocja: ");
            IzpisRegistrskeSt("GO", tabelaRegistracij);
            Console.WriteLine();
            IzpisRegistrskeSt("LJ", tabelaRegistracij);
            Console.WriteLine();
            IzpisRegistrskeSt("MB", tabelaRegistracij);
            Console.WriteLine();

            Console.WriteLine("Izlocimo naredkeje in najpogosteje uporabljena obmocja: ");
            int k = 1;
            foreach (Registracija reg in tabelaRegistracij)
            {
                Console.WriteLine(k + ": " + reg);
                k++;
            }
            Console.WriteLine();

            Odstrani(ref tabelaRegistracij);

            int i = 1;
            foreach (Registracija reg in tabelaRegistracij)
            {
                Console.WriteLine(i + ": " + reg);
                i++;
            }

        }

        /// <summary>
        /// Metoda izpise registrske tablice obmocja
        /// </summary>
        /// <param name="obmocje"></param>
        /// <param name="tabRegistracij"></param>
        public static void IzpisRegistrskeSt(string obmocje, Registracija[] tabRegistracij)
        {
            int i = 1;
            foreach (Registracija niz in tabRegistracij) //gremo cez vse registracije v tabeli registracij
            {
                if (niz.Obmocje == obmocje)
                {
                    Console.WriteLine(i + ": " + niz);
                    i++;
                }
            }
        }

        /// <summary>
        /// S tabele registracij odstrani tisto, ki se pojavi najveckrat in tisto, ki se pojavi najmanjkrat.
        /// Ce je takih registracij vec, odstranimo prvo v tabeli. 
        /// </summary>
        /// <param name="tabelaRegistracij"></param>
        public static void Odstrani(ref Registracija[] tabelaRegistracij)
        {
          
            string[] tabelaObmocij = tabelaRegistracij[1].Tabela_Obmocja; 
            int[] koliko_obmocij = new int[tabelaObmocij.Length]; //kolikokrat se posamezno obmocje pojavi v tabeli
            foreach (Registracija niz in tabelaRegistracij) 
            {
                for (int i = 0; i < tabelaObmocij.Length; i++)
                {
                    if (niz.Obmocje == tabelaObmocij[i]) //ce je v registraciji obmocje enako obmocju v tabeli vseh na i-tem mestu
                    {
                        koliko_obmocij[i] = koliko_obmocij[i] + 1; //ga pristejemo
                        break;
                    }
                }
            }

            int najredkejse_obmocje = koliko_obmocij.Min();
            int najpogostejse_obmocje = koliko_obmocij.Max();
            string[] tab_min_max = new string[2]; //tabela najredkeje in najpogosteje uporabljenega obmocja
            

            for (int i = 0; i < koliko_obmocij.Length; i++) //najredkeje uporabljeno obmocje
            {
                if (koliko_obmocij[i] == najredkejse_obmocje)
                {
                    tab_min_max[0] = tabelaObmocij[i];
                    break;
                }
            }

            for (int i = 0; i < koliko_obmocij.Length; i++) //najpogosteje uporabljeno obmocje
            {
                if (koliko_obmocij[i] == najpogostejse_obmocje)
                {
                    tab_min_max[1] = tab_min_max[0];
                    tab_min_max[1]  = tabelaObmocij[i];
                    break;
                }
            }


            //v novo tabelo dodamo registracije ki niso v tabeli tab_min_max
            Registracija[] tabelaNovihRegistracij = new Registracija[tabelaRegistracij.Length - najpogostejse_obmocje - najredkejse_obmocje];
            int k = 0;
            for (int i = 0; i < tabelaRegistracij.Length; i++)
            {
                if (tabelaRegistracij[i].Obmocje != tab_min_max[0] && tabelaRegistracij[i].Obmocje != tab_min_max[1])
                {
                    tabelaNovihRegistracij[k] = tabelaRegistracij[i];
                    k++;
                }
            }
            tabelaRegistracij = tabelaNovihRegistracij;
        }
        /// <summary>
        /// Ustvari nakljucno registersko številko
        /// </summary>
        /// <param name="koliko"></param>
        /// <returns></returns>
        public static string RandomString(int dolzina_reg)
        {
            Random random = new Random();
            char velika_crka;
            char[] tab_znakov = new char[dolzina_reg]; 
            for (int i = 0; i < dolzina_reg; i++)
            {
                velika_crka = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))); // velke tiskane crke
                int stevka = random.Next(35); 
                if (stevka < 10) //namesto crke dodamo stevko v registracijo
                {
                    velika_crka = char.Parse(stevka.ToString()); // zapis stevil v registracijo
                }
                tab_znakov[i] = velika_crka;
            }
            string niz = ""; //"0123456789ABCDEFGHIJKLMNOPRSTUVZ"
            foreach (char znak in tab_znakov)
            {
                niz += znak;
            }
            return niz;
        }
    }
}
