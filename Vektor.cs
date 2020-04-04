using System;
using System.Collections.Generic;
using System.Text;

namespace Razred_vektor
{
    public class Vektor
    {
        private int x;
        private int y;

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Length
        {
            get { return Math.Pow((Math.Pow(this.x, 2) + Math.Pow(this.y, 2)), 0.5); }

        }

        public override string ToString()
        {
            string niz = "[" + this.x.ToString() + ", " + this.y.ToString() + "]";
            return niz;
        }

        /// <summary>
        /// Konstruktor vektor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Vektor(int a, int b)
        {
            this.x = a;
            this.y = b;
        }

        //nicelni vektor
        public Vektor()
        {
            this.X = 0;
            this.Y = 0;
        }
        //vsota dveh vektorjev
        public static Vektor operator +(Vektor v1, Vektor v2)
        {
            return new Vektor(v1.X + v2.X, v1.Y + v2.Y);
        }

        //razlika dveh vektorjev
        public static Vektor operator -(Vektor v1, Vektor v2)
        {
            return new Vektor(v1.X - v2.X, v1.Y - v2.Y);
        }

        /// <summary>
        /// Metodi za množenje vektorja s skalarjem (z leve in z desne strani)
        /// </summary>
        /// <param name="skalar"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Vektor operator *(int skalar, Vektor v1)
        {
            return new Vektor(skalar * v1.X, skalar * v1.Y);
        }

        public static Vektor operator *(Vektor v1, int skalar)
        {
            return new Vektor(v1.X * skalar, v1.Y * skalar);
        }

        /// <summary>
        /// Skalarni produkt dveh vektorjev
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static int operator *(Vektor v1, Vektor v2)
        {
            return (v1.X * v2.X + v1.Y * v2.Y);
        }

        /// <summary>
        /// Računski operator za povečanje koordinat za 1 enoto
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Vektor operator ++(Vektor v1)
        {
            v1.X++;
            v1.Y++;
            return v1;
        }

        /// <summary>
        /// Računski operator za zmanjšanje koordinat za 1 enoto
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Vektor operator --(Vektor v1)
        {
            v1.X--;
            v1.Y--;
            return v1;
        }
        /// <summary>
        /// Nasprotno usmerjen vektor
        /// </summary>
        public static Vektor operator -(Vektor v1)
        {
            return new Vektor(-v1.X, -v1.Y);
        }

        public bool Equals(Vektor v2)
        {
            if (this.X == v2.X && this.Y == v2.Y) { return true; }
            return false;
        }

        public static bool operator <(Vektor v1, Vektor v2)
        {
            return (v1.Length < v2.Length);
        }

        public static bool operator >(Vektor v1, Vektor v2)
        {
            return (v1.Length > v2.Length);
        }

        public static bool operator <=(Vektor v1, Vektor v2)
        {
            return (v1.Length <= v2.Length);
        }

        public static bool operator >=(Vektor v1, Vektor v2)
        {
            return (v1.Length >= v2.Length);
        }

        public static bool operator ==(Vektor v1, Vektor v2)
        {
            return (v1.X == v2.X && v1.Y == v2.Y);
        }

        public static bool operator !=(Vektor v1, Vektor v2)
        {
            return (v1.X != v2.X || v1.Y != v2.Y);
        }

        public static bool operator !(Vektor v1)
        {
            return (v1.X == 0) & (v1.Y == 0);
        }

        public static bool operator true(Vektor v1)
        {
            return v1.Equals(new Vektor());
        }

        public static bool operator false(Vektor v1)
        {
            return !v1.Equals(new Vektor());
        }

        public static bool operator &(Vektor v1, Vektor v2)
        {
            bool v1flag = !((v1.X == 0) && (v1.Y == 0));
            bool v2flag = !((v2.X == 0) && (v2.Y == 0));
            return v1flag & v2flag;
        }

        public static bool operator |(Vektor v1, Vektor v2)
        {
            bool v1flag = !((v1.X == 0) && (v1.Y == 0));
            bool v2flag = !((v2.X == 0) && (v2.Y == 0));

            return v1flag | v2flag;
        }

        public static bool operator ^(Vektor v1, Vektor v2)
        {
            bool v1flag = !((v1.X == 0) && (v1.Y == 0));
            bool v2flag = !((v2.X == 0) && (v2.Y == 0));

            return v1flag ^ v2flag;
        }

        public static implicit operator double(Vektor v1)
        {
            return v1.Length;
        }

        public static explicit operator float(Vektor v1)
        {
            return (float)v1.Length;
        }

    }

}








