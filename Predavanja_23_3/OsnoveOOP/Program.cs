using System;

namespace OsnoveOOP
{
    public class MojR
    {
        //opis metod

        public void Pozdrav()
        {
            Console.WriteLine("OOP v vsako slovensko vas!");
        }

        public void Pozdrav2()
        {
            Console.WriteLine("Vsekakor OOP!");
        }
    }
    public class SlabUlomek
    {
        public int im;
        public int st;
    }

    class Ulomek
    {
        //do teh podatkov ne more priti nihče od zunaj
        private int im;
        private int st;

        public void NastaviIm(int x)
        {
            if (x == 0) throw new Exception("Imenovalec ne more biti 0");
            this.im = x;
        }

        public void NastaviSt(int x) 
        {
            this.st = x;
        }

        public int PovejSt()
        {
            return this.st;
        }

        public int PovejIm()
        {
            return this.im;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MojR objekt1;
            objekt1 = new MojR();
            objekt1.Pozdrav2();

            MojR o2 = new MojR();
            o2.Pozdrav();

            SlabUlomek mojU = new SlabUlomek();
            mojU.im = 12;
            mojU.st = mojU.im + 1;

            Console.WriteLine(mojU.st + "/" + mojU.im);
            Console.WriteLine(mojU.ToString());

            
        }
    }
}
