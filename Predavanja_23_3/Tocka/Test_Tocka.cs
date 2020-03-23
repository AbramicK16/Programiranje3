using System;

namespace Tocka
{

    public class Točka
    {
        private int x;
        private int y;

        public Točka(int tx, int ty)
        {
            this.X = tx;
            this.Y = ty;
        }

        public int X //lastnost
        {
            get { return this.x; }
            set 
            {
                if (value < 0) throw new Exception("Točka ni v 1. kvadrantu");
                this.x = value;
            }
        }

        public int Y //lastnost
        {
            get { return this.y; }
            set
            {
                if (value < 0) throw new Exception("Točka ni v 1. kvadrantu");
                this.y = value;
            }
        }
        public void NastaviX(int tx)
        {
            if (tx > 0) throw new Exception("Točka mora biti v 1. kvadrantu");
            this.x = tx;
        }

        public void NastaviY(int tx)
        {
            if (tx > 0) throw new Exception("Točka mora biti v 1. kvadrantu");
            this.x = tx;
        }

        public int PovejX()
        {
            return this.x;
        }

        public int PovejY()
        {
            return this.y;
        }
        public override string ToString() //metoda, ki vraca tip string
        {
            return "(" + this.X + ", " + this.Y + ")";
        }
    }
    class Test_Tocka
    {
        static void Main(string[] args)
        {
            Točka mojaT = new Točka(2, 5);
            Console.WriteLine(mojaT);
            //Console.WriteLine(mojaT.ToString());
            //mojaT.NastaviX(-7);
            try
            {
                mojaT.X = -3;
            }
            catch
            {
                Console.WriteLine(mojaT);
            }
        }
    }
}
