using System;

namespace razred1
{
    public class Ulomek
    {
        public int st;
        public int im;

        public Ulomek()
        {
            this.st = 1; //this ima enako vlogo kot self v py..objekt nad katerim izvajamo doloceno metodo
            this.im = 2;
        }

        public string Opis()
        {
            return this.st + " / " + this.im;
            //return this.st + @" \ " + this.im; //@\ -> \ je obicajni znak
        }
    }

    public class Ulomek1
    {
        public int[] pod = new int[2];

        public Ulomek1()
        {
            this.pod[0] = 1;
            this.pod[1] = 2;
        }
    }


    public class UlomekNov
    {
        private int[] podatki = new int[2];
        // kje hranimo podatke
        //private int st;
        //private int im;

        public UlomekNov() // konstruktor
        {
            this.NastaviSt(1);
            this.NastaviIm(2);
        }

        public int PovejSt()
        { return this.podatki[0]; }

        public int PovejIm()
        { return this.podatki[1]; }

        public void NastaviIm(int kol)
        {
            if (kol == 0) throw new Exception("Imenovalec ne more biti 0!");          
            this.podatki[1] = kol; 
        }

        public void NastaviSt(int kol)
        { this.podatki[0] = kol; }

        /// vrne niz z opisom ulomka
        public string Opis()
        {
            return this.podatki[0] + " / " + this.podatki[1];
        }


        class Test_osnove
    {
            static void Main(string[] args)
            {
                // dva objekta
                UlomekNov moj1 = new UlomekNov();
                UlomekNov moj2 = new UlomekNov();

                Console.WriteLine(moj1.Opis());
                Console.WriteLine(moj2);

                moj1.st = 3;
                moj1.im = 4;
                Console.WriteLine(moj1.Opis());
                moj2.im = moj1.st + 10;
                Console.WriteLine(moj2.Opis());
                moj1.im = 0;
                Console.WriteLine(moj1.Opis());

                //in se z UlomekNov

                UlomekNov tvoj1;
                UlomekNov tvoj2 = new UlomekNov();
                tvoj1 = new UlomekNov();
                Console.WriteLine(tvoj1.Opis());
                tvoj1.NastaviSt(0);
                Console.WriteLine(tvoj1.Opis());
                tvoj1.NastaviSt(31);
                Console.WriteLine(tvoj1.Opis());

                try
                {
                    tvoj1.NastaviIm(0);
                    Console.WriteLine(tvoj1.Opis());
                }
                catch { Console.WriteLine(tvoj1.Opis()); }

                UlomekNov tvoj3 = new UlomekNov();
                UlomekNov tvoj4 = new UlomekNov();
                tvoj3.NastaviSt(3);
                tvoj3.NastaviIm(4);

                //tvoj4 naj ima stevec za 1 vecji od imenovalca tvoj3

                tvoj4.NastaviIm(1 + tvoj3.PovejIm());

                //

                tvoj4.im = 3 - tvoj3.st;




            }
        }
    }
}
