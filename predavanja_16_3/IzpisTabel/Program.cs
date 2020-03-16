using System;
using System.Collections.Generic;


namespace IzpisTabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabStevil = new int[] { 23, 5, 6, 7 };
            string[] tabNizov = new string[] { "bla", "ble", "blo", "blu" };
            int[] tabStevil1 = new int[] { 123, 15, 34, 6, 7 };
            string[] tabNizov1 = new string[] { "bla", "e", "blu" };
            int[] tabStevil2 = new int[] { 23, 5, 6, 71, 98, 42 };
            string[] tabNizov2 = new string[] { "bla", "ble", "blo", "blu" };
            IzpisTabele(tabStevil1);
            IzpisTabele(tabNizov);
            IzpisTabele(tabStevil1);
            IzpisTabele(tabNizov2);


            IzpisVecji("matija", "mojca");
            IzpisVecji(12.98, 78.6);
            IzpisVecji("cr", "block");

        }

        public static void IzpisVecji<T>(T pod1, T pod2) where T : IComparable<T>
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
            Console.WriteLine("Vecji podatek je: " + vecji);
        }
        public static T VrniVecji<T>(T pod1, T pod2) where T : IComparable<T>
        {
            if (pod1.CompareTo(pod2) >= 0) return pod1;
            return pod2;
            
        }

        public static void IzpisTabele<Karkoli>(Karkoli[] tab)
        {
            foreach (Karkoli el in tab)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
