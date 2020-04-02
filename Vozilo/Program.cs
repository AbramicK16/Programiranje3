using System;

namespace Vozilo
{
    public class Vozilo
    {
        private double gorivo;
        private double kapaciteta;
        private double poraba;

        public double Gorivo
        {
            get { return this.gorivo; }
            set
            {
                if (value < 0) throw new Exception("Rezervoar ne more biti še bolj prazen");
                else if (value > this.kapaciteta) throw new Exception("Rezervoar ne moreš napolniti več kot je kapaciteta");
                this.gorivo = value;
            }
        }

        public double Kapaciteta
        {
            get { return this.kapaciteta; }
            set
            {
                if (value < 0) throw new Exception("Kapaciteta ne more biti negativa");
                this.kapaciteta = value;
            }
        }

        public double Poraba
        {
            get { return this.poraba; }
            set
            {
                if (value <= 0) throw new Exception("Poraba na 100km ne more biti manjša ali enaka nič");
                this.poraba = value;
            }
        }
        /// <summary>
        /// Konstruktor, ki dobi podani vrednosti za kapaciteto in porabo. 
        /// Trenutno zalogo goriva pa nastavi kar enako kapaciteti. 
        /// </summary>
        /// <param name="vozilo_kapaciteta"></param>
        /// <param name="vozilo_poraba"></param>
        public Vozilo(double vozilo_kapaciteta, double vozilo_poraba)
        {
            this.Kapaciteta = vozilo_kapaciteta;
            this.Poraba = vozilo_poraba;
            this.Gorivo = vozilo_kapaciteta;
        }

        /// <summary>
        /// Lastnost, ki vrne stevilo kilometrov, ki jih vozilo se lahko prevozi
        /// s trenutno zalogo goriva.
        /// </summary>
        /// <returns></returns>
        public double PreostaliKilometri()
        {
            return 100 * (this.gorivo / this.poraba);
        }

        /// <summary>
        /// Metoda - Napolni rezervoar tako, da je poln.
        /// </summary>
        public void Crpalka() //ne napisemo static void, ker this ni staticna metoda
        {
            this.Gorivo = this.Kapaciteta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="km"></param>
        public void Prevozil(double km)
        {
            this.Gorivo = this.Gorivo - poraba * (km / 100.0);
        }

        public bool Ali_lahko_prevozi(double[] pot)
        {
            double v_rezervoarju = this.Gorivo;
            foreach (double km in pot)
            {
                if (km < 0)
                {
                    throw new Exception("Pot ne more biti negativna.");
                }
                if (km == 0 && v_rezervoarju == this.Kapaciteta)
                {
                    throw new Exception("Vozilo je napolnjeno.");
                }
                if (km > 0)
                {
                    v_rezervoarju = v_rezervoarju - km * this.Poraba / 100;
                }
                else
                {
                    v_rezervoarju = this.Kapaciteta;
                }
                if (v_rezervoarju < 0)
                {
                    return false;
                }
            }
            this.Gorivo = v_rezervoarju;
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo vozilo = new Vozilo(105.0, 50.0);
            //if (vozilo.Kapaciteta == 105)
            //{
              //  Console.WriteLine(1);
            //}
            //else
            //{
              //  Console.WriteLine(0);
            //}

            //if (vozilo.Poraba == 50)
            //{
              //  Console.WriteLine(1);
            //}
            //else
            //{
              //  Console.WriteLine(0);
            //}

            //try
            //{
              //  Vozilo vozilo1 = new Vozilo(105.0, -50.0);

            //}
            //catch (Exception)
            //{
                
            //}
           
            Console.WriteLine(vozilo.PreostaliKilometri());

            Vozilo vozilo11 = new Vozilo(85.0, 30.0);
            Vozilo vozilo33 = new Vozilo(155.0, 30.0);

            //če zmanjka goriva ali gramo 2-krat zapored na črpalko razred vrne napako
            try
            {
                Console.WriteLine(vozilo11.Ali_lahko_prevozi(new double[5] { 630.0, 100.0, 280.0, 130.0, 0.0 }));
            }
            catch (Exception)
            {
                
            }
            
            try
            {
                Console.WriteLine(vozilo33.Ali_lahko_prevozi(new double[4] { 200.0, 0.0, 100.0, 0.0 }));
            }
            catch (Exception)
            {
                
            }
        }
    }
}