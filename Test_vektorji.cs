using System;

namespace Razred_vektor
{
    class Test_vektorji
    {
        static void Main(string[] args)
        {
            Vektor v1 = new Vektor(3, 4);           
            Vektor v2 = new Vektor(2, -3);
            Vektor v3 = new Vektor();
            Vektor v4 = new Vektor(3, 4);
            Console.WriteLine("({0},{1})", v3.X, v3.Y); //nicelni vektor v3

            Vektor v5 = v1 + v2;
            Console.WriteLine("({0},{1})", v5.X, v5.Y);

            Vektor v6 = v1 - v2;
            Console.WriteLine("({0},{1})", v6.X, v6.Y);

            Vektor v7 = v1 * 1;
            Console.WriteLine("({0},{1})", v7.X, v7.Y);

            Vektor v8 = 1 * v2;
            Console.WriteLine("({0},{1})", v8.X, v8.Y);

            Vektor v9 = v1++;
            Console.WriteLine("({0},{1})", v9.X, v9.Y);

            Vektor v10 = v3--;
            Console.WriteLine("({0},{1})", v10.X, v10.Y);

            Vektor v11 = -v2;
            Console.WriteLine("({0},{1})", v11.X, v11.Y);
            Console.WriteLine("Logični izrazi: ");
            Console.WriteLine(v1 == v2); 
            Console.WriteLine(v1 == v4);
            Vektor v12 = v1;
            Console.WriteLine(v12 == v1);

            Console.WriteLine(v12 != v1);
            Console.WriteLine(v1 != v4);
            Console.WriteLine(v1 != v2);

            Console.WriteLine(v1 > v3); 
            Console.WriteLine(v1 < v3); 
            Console.WriteLine(v1 >= v3);
            Console.WriteLine(v1 <= v3);
            Console.WriteLine(v1 & v3);
            Console.WriteLine(v1 | v3);
            Console.WriteLine(v1 ^ v3);

        }
    }
}

