
using System;


namespace KvadratnaEnacna
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            NicleKvadratneEnacne(a, b, c);

        }


        public static void NicleKvadratneEnacne(int a, int b, int c)
        {
            double x1;
            double x2;
            //Console.WriteLine("Poišči ničli kvadratne enačbe");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Convert.ToInt32(Console.ReadLine());
            double determinanta;
            determinanta = (b * b) - (4 * a * c);

            if (determinanta == 0)
            {


                Console.WriteLine("NIčli sta enaki");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine("Prva ničla={0}", x1);
                Console.WriteLine("Druga ničla={1}", x2);
                //return NicleKvadratneEnacne(a, b, c);

            }

            else if (determinanta > 0)
            {


                Console.WriteLine("NIčli sta realni in različni");
                x1 = -b + Math.Sqrt(determinanta) / (2.0 * a);
                x2 = -b - Math.Sqrt(determinanta) / (2.0 * a);

                Console.WriteLine("Prva ničla={0}", x1);
                Console.WriteLine("Druga ničla={0}", x2);
                //return NicleKvadratneEnacne(a, b, c);

            }

            else
                Console.WriteLine("Ničli sta imaginarni");
            //return NicleKvadratneEnacne(a, b, c);
            //Console.ReadLine();
        }
    }
}
