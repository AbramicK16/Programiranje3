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
