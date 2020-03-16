using System;

namespace Lovljenje_napak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sporocilo = "Vnesi celo število: ";
            preberiInt("Vnesi celo število: ");
            PreberiIntMeje("Vnesi celo število med ", st1, st2);
        }
        public static int preberiInt(string sporocilo)
        {
            Console.Write(sporocilo);
            try
            {

                int stevilo = int.Parse(Console.ReadLine());
                return stevilo;

            }

            catch (FormatException)
            {

                Console.WriteLine("Vnesti moraš celo število.");
                return preberiInt(sporocilo);
            }

            catch (Exception e)
            {

                Console.WriteLine("Nekaj je šlo narobe");

                Console.WriteLine(e.ToString());
                Console.WriteLine("Popravi program, da bo to izjemo obravnaval posebej");
                return preberiInt(sporocilo);
            }
        }

        public static int PreberiIntMeje(int st1, int st2)
        {
            Console.Write(st1);
            Console.Write(st2);

        try
            {
                int stevilo = 
            }



        }
            

            

        }
    }
}
