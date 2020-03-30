using System;

namespace Student
{
    public class Student
    {
        //za vsakega studenta poznamo njegovo ime, stevilko cevljev, IQ

        private string ime;
        private int st_cevljev;
        private int iq;

        //definiramo lastnosti
        public string Ime
        {
            get { return this.ime; }
            //set..ime maš dovoljeno in ga ne moreš več spreminjat
        }

        public int StCevlji
        {
            get { return this.st_cevljev; }
            set
            {
                if ((value < 30) || (value > 60)) throw new Exception("Nesmiselna številka čevljev");
                this.st_cevljev = value;
            }
        }

        public int IQ
        {
            get { return this.iq; }
            set
            {
                if ((value < 0) || (value > 200)) throw new Exception("Nesmiseln IQ");
                this.iq = value;
            }
        }

        public override string ToString()
        {
            return this.Ime + " ima IQ " + this.IQ + " in številko čevljev " + this.StCevlji + ".";
        }

        public Student(string imeS, int sIQ = 100, int stC = 40)
        {
            if (ime.Length == 0) throw new Exception("Ime ne sme biti prazen niz");
            this.ime = imeS;
            this.IQ = sIQ;
            this.StCevlji = stC;
            }

    }
    class Test_Student
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

