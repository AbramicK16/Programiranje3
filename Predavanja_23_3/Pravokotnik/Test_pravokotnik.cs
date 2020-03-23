using System;

namespace Pravokotnik
{

    public class Pravokotnik
    {
        private int strA;
        private int strB;


        public int A
        {
            get { return this.strA; }
            set
            {
                if (value < 0) throw new Exception("Stranica mora biti pozitivna");
                this.strA = value;
            }
        }

        public int B
        {
            get { return this.strB; }
            set
            {
                if (value < 0) throw new Exception("Stranica mora biti pozitivna");
                this.strB = value;
            }
        }

        public Pravokotnik(int sA, int sB)
        {
            this.A = sA;
            this.B = sB;

        }

        public int Ploscina()
        {
            return this.A * this.B;
        }

        public int Obseg()
        {
            return 2 * (this.A + this.B);
        }

        public override string ToString()
        {
            return this.A + " x " + this.B;
        }
    }

    class Test_pravokotnik
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program, ki uporablja pravokotnike");
            Pravokotnik prvi = new Pravokotnik(2, 5);
            Console.WriteLine("Pravokotnik" + prvi + " ima ploščino " + prvi.Ploscina());
            // spremenimo stranico B na  4
            prvi.B = 4;
            Console.WriteLine("Pravokotnik" + prvi + " ima ploščino " + prvi.Ploscina());
        }
    }
}
