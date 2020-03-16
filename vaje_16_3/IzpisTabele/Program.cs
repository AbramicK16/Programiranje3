using System;

namespace IzpisTabele
{
    class Program
    {
        public static void IzpisTabele<Karkoli>(Karkoli[] tab)
        {
            foreach (Karkoli el in tab)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        public static void IzpisiVecji<T>(T pod1, T pod2) where T : IComparable<T>
        {
            T vecji;
            if (pod1.CompareTo(pod2) > 0)
            {
                vecji = pod1;
            }
            else
            {
                vecji = pod2;
            }
            Console.WriteLine("Večji podatek je: " + vecji);
        }
        static void Main(string[] args)
        {
            int[] tabStevil = new int[] { 23, 5, 6, 7 };
            string[] tabNizov = new string[] { "bla", "ble", "blo", "blu" };
            IzpisTabele(tabStevil);
            IzpisTabele(tabNizov);
            IzpisiVecji(12, 3);
        }
    }
}
