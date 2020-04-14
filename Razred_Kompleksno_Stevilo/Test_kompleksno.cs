using System;

namespace Razred_Kompleksno_Stevilo
{
    class Test_kompleksno
    {
        static void Main(string[] args)
        {
            Kompleksno_stevilo k1 = new Kompleksno_stevilo (3, -2);
            Kompleksno_stevilo k2 = new Kompleksno_stevilo (5, 9);

            Kompleksno_stevilo vsota = k1 + k2;
            Console.WriteLine ("Prvo kompleksno št: {0}", k1);
            Console.WriteLine ("Drugo kompleksno št: {0}", k2);
            Console.WriteLine ("Vsota: {0}", vsota);

            Kompleksno_stevilo k3 = new Kompleksno_stevilo (0, -3);
            Console.WriteLine (k3);
            Console.WriteLine (k3.R);
            Console.WriteLine (k3.Arg);
            Console.WriteLine (k1.Arg);

        }
    }
}
