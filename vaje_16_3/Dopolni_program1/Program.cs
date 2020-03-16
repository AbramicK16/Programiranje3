using System;

namespace Dopolni_program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program izpiše vrednost izraza (a+b)/c, za cela števila a,b,c");
            try
            {
                Console.Write("Vnesi a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Vnesi b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Vnesi c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("(a+b)/c = " + ((a + b) / c));
            }

            //uporabiti moramo celo stevilo
            catch (FormatException)
            {
                Console.WriteLine("Vpišeš lahko samo cela števila");
            }

            catch (DivideByZeroException) //ce delimo z 0
            {

                Console.WriteLine("Deliš z nič");
            }

            
            catch (Exception e) //ce gre nekaj drugega narobe
            {
                Console.WriteLine("Nekaj je šlo narobe");

                Console.WriteLine(e.ToString());
                Console.WriteLine("Popravi program, da bo to izjemo obravnaval posebej");
            }

            // je potem vse OK s to nalogo?




        }
    }
}
