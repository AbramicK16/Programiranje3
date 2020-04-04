using System;

namespace Razred_kosarica
{
    class Test_kosaric
    {
        static void Main(string[] args)
        {
            Kosarica<int> kosarica_celih = new Kosarica<int>(5);
            Console.WriteLine(kosarica_celih);
            Kosarica<string> kosarica_nizov = new Kosarica<string>("Programiranje");
            Console.WriteLine(kosarica_nizov);
            Kosarica<double> kosarica_realnih = new Kosarica<double>(3.14);
            Console.WriteLine(kosarica_realnih);

            int[] tab = new int[] { 2, 4, 6, 8 };
            Kosarica<int[]> kosarica_tabel = new Kosarica<int[]>(tab);
            Console.WriteLine(kosarica_tabel);




        }
    }
}
