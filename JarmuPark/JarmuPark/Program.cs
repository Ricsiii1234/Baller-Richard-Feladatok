using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    abstract class Jarmu
    {
        public string Azonosito { get; private set; }
        public string Rendszam { get; set; }
        public int GyartasiEv { get; private set; }
        public double Fogyasztas { get; set; }

        public double FutottKm { get; private set; }
        public int AktualisKoltseg { get; private set; }
        public bool Szabad { get; private set; }

        public static int AktualisEv { get; set; }
        public static int AlapDij { get; set; }
        public static double Haszonkulcs { get; set; }


        //Konstruktorok

        // Ha ismerjük a fogyasztást
        public Jarmu(string azonosito, string rendszam, int gyartasiEv, double fogyasztas)
        {
            this.Azonosito = azonosito;
            this.Rendszam = rendszam;
            this.GyartasiEv = gyartasiEv;
            this.Fogyasztas = fogyasztas;
            this.Szabad = true;
        }

        // Ha nem ismerjük a fogyasztást
        public Jarmu(string azonosito, string rendszam, int gyartasiEv)
        {
            this.Azonosito = azonosito;
            this.Rendszam = rendszam;
            this.GyartasiEv = gyartasiEv;
            this.Szabad = true;
        }

        // Jármű korának kiszámolása

        public int Kor()
        {
            return AktualisEv - GyartasiEv;
        }

        // Fuvarozás

        public bool Fuvaroz(double ut, int benzinAr)
        {
            if (Szabad)
            {
                FutottKm += ut;
                AktualisKoltseg = (int)(benzinAr * ut * Fogyasztas / 100);
                Szabad = false;
                return true;
            }

            return false;
        }

        // Alap bérletidíj kiszámolása

        public virtual int BerletiDij()
        {
            return (int)(AlapDij + AktualisKoltseg + AktualisKoltseg * Haszonkulcs / 100);
        }

        // Ha végzett legyen Szabad újra

        public void Vegzett()
        {
            Szabad = true;
        }

        public override string ToString()
        {
            return "\nA " + this.GetType().Name.ToLower() + " azonosítója: " + Azonosito + "\nrendszáma: " + Rendszam + "\nkora: " + Kor() + " év" + "\nfogyasztása: " + Fogyasztas + "l/100km" + "\na km-óra állása: " + FutottKm + " km.";
        }
    }

        class Busz : Jarmu
        {
            // Tulajdonságok
            public int Ferohely { get; private set; }
            public static double Szorzo { get; set; }

            // Konstruktorok

            // Ha tudjuk a fogyasztást
            public Busz(string azonosito, string rendszam, int gyartasiEv, double fogyasztas, int ferohely) : base(azonosito, rendszam, gyartasiEv, fogyasztas)
            {
                this.Ferohely = ferohely;
            }

            // Ha nem tudjuk a fogyasztást

            public Busz(string azonosito, string rendszam, int gyartasiEv, int ferohely) : base(azonosito, rendszam, gyartasiEv)
            {
                this.Ferohely = ferohely;
            }

            // metódusok
            // Kiszámolja a busz bérletidíját

            public override int BerletiDij()
            {
                return (int)(base.BerletiDij() + Ferohely * Szorzo);
            }

            public override string ToString()
            {
                return base.ToString() + "\n\tférőhelyek száma: " + Ferohely;
            }
        }

    

    class Teherauto : Jarmu
    {
        // tulajdonságok

        // Konstruktorok, fogyasztással és anélkül
        public double TeherBiras { get; private set; }
        public static double Szorzo { get; set; }

        public Teherauto(string azonosito, string rendszam, int gyartasiEv, double fogyasztas, double teherBiras) : base (azonosito, rendszam, gyartasiEv, fogyasztas)
        {
            this.TeherBiras = teherBiras;
        }

        public Teherauto(string azonosito, string rendszam, int gyartasiEv, double teherBiras) : base (azonosito, rendszam, gyartasiEv)
        {
            this.TeherBiras = teherBiras;
        }

        // Metódusok
        // Kiszámolja a teherautó bérletdíját

        public override int BerletiDij()
        {
            return (int)(base.BerletiDij() + TeherBiras * Szorzo);
        }

        public override string ToString()
        {
            return base.ToString() + "\n\tteherbírás: " + TeherBiras + " tonna.";
        }
    }

    class Vezerles
    {
        private List<Jarmu> jarmuvek = new List<Jarmu>();
        private string BUSZ = "busz";
        private string TEHER_AUTO = "teherautó";

        public void Indit()
        {
            StatikusBeallitas();
            AdatBevitel();
            Kiir("A regisztrált jármüvek: ");
            Mukodtet();
            Kiir("\nA müködés utáni állapot: ");
            AtlagKor();
            LegtobbKilometer();
            Rendez();
        }

        public void StatikusBeallitas()
        {
            // Statik adatok beolvasása (be is lehetne olvasni)
            Jarmu.AktualisEv = 2015;
            Jarmu.AlapDij = 1000;
            Jarmu.Haszonkulcs = 10;

            Busz.Szorzo = 15;
            Teherauto.Szorzo = 8.5;
        }

        private void AdatBevitel()
        {
            string tipus, rendszam, azonosito;
            int gyartEv, ferohely;
            double fogyasztas, teherbiras;

            StreamReader olvasocsatorna = new StreamReader("jarmuvek.txt");

            int sorszam = 1;

            while (!olvasocsatorna.EndOfStream)
            {
                tipus = olvasocsatorna.ReadLine();
                Console.WriteLine(tipus);
                rendszam = olvasocsatorna.ReadLine();
                gyartEv = int.Parse(olvasocsatorna.ReadLine());
                fogyasztas = double.Parse(olvasocsatorna.ReadLine());
                azonosito = tipus.Substring(0, 1).ToUpper() + sorszam;

                if (tipus == BUSZ)
                {
                    ferohely = int.Parse(olvasocsatorna.ReadLine());
                    jarmuvek.Add(new Busz(azonosito, rendszam, gyartEv, fogyasztas, ferohely));
                }
                else if (tipus == TEHER_AUTO)
                {
                    teherbiras = double.Parse(olvasocsatorna.ReadLine());
                    jarmuvek.Add(new Teherauto(azonosito, rendszam, gyartEv, fogyasztas, teherbiras));
                }
                sorszam++;
            }
            olvasocsatorna.Close();
        }

        private void Kiir(string cim)
        {
            Console.WriteLine(cim);
            foreach(Jarmu jarmu in jarmuvek)
            {
                Console.WriteLine(jarmu);
            }
        }

        private void Mukodtet()
        {
            int osszKoltseg = 0, osszBevetel = 0;

            Random rand = new Random();
            int alsoBenzinAr = 400, felsoBenzinAr = 420;
            double utMax = 300;
            int mukodesHatar = 200;
            int jarmuIndex;

            Jarmu jarmu;
            int fuvarSzam = 0;

            for (int i = 0; i < (int)rand.Next(mukodesHatar); i++)
            {
                jarmuIndex = rand.Next(jarmuvek.Count());
                jarmu = jarmuvek[jarmuIndex];
                if (jarmu.Fuvaroz(rand.NextDouble() * utMax, rand.Next(alsoBenzinAr, felsoBenzinAr)))
                {
                    fuvarSzam++;
                    Console.WriteLine("\nAz induló jármű rendszáma: " + jarmu.Rendszam + "\nAz aktuális fuvarozási költség: " + jarmu.AktualisKoltseg + " Ft." + "\nAz aktuális bevétel: " + jarmu.BerletiDij() + " Ft.");

                    osszBevetel += jarmu.BerletiDij();
                    osszKoltseg += jarmu.AktualisKoltseg;
                }

                jarmuIndex = rand.Next(jarmuvek.Count);
                jarmuvek[jarmuIndex].Vegzett();
            }

            Console.WriteLine("\n\nA cég teljes költsége: " + osszKoltseg + " Ft." + "\n\nTeljes bevétele: " + osszBevetel + " Ft." + "\n\nHaszna: " + (osszBevetel - osszKoltseg) + " Ft.");
            Console.WriteLine("\nFuvarok száma: " + fuvarSzam);
        }


        private void AtlagKor()
        {
            double osszKor = 0;
            int darab = 0;
            foreach (Jarmu jarmu in jarmuvek)
            {
                osszKor += jarmu.Kor();
                darab++;
            }

            if (darab > 0)
            {
                Console.WriteLine("\nA járművek átlag kora: " + osszKor / darab + " év.");
            }
            else
            {
                Console.WriteLine("Nincsenek járművek.");
            }
        }

        private void LegtobbKilometer()
        {
            double max = jarmuvek[0].FutottKm;
            foreach (Jarmu jarmu in jarmuvek)
            {
                if (jarmu.FutottKm == max)
                {
                    Console.WriteLine(jarmu.Rendszam);
                }
            }
        }

        private void Rendez()
        {
            Jarmu temp;

            for (int i = 0; i < jarmuvek.Count() - 1; i++)
            {
                for (int j = i; (j < jarmuvek.Count()); j++)
                {
                    if (jarmuvek[i].Fogyasztas > jarmuvek[j].Fogyasztas)
                    {
                        temp = jarmuvek[j];
                        jarmuvek[i] = jarmuvek[j];
                        jarmuvek[j] = temp;

                    }
                }
            }

            Console.WriteLine("\nA járművek fogyasztása szerint rendezve: ");

            foreach (Jarmu jarmu in jarmuvek)
            {
                Console.WriteLine("{0,10} {1:00.0} liter / 100km.", jarmu.Rendszam, jarmu.Fogyasztas);
            }
        }

    }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Jarmu> jarmuvek = new List<Jarmu>();

                for (int i = 0; i < jarmuvek.Count(); i++)
            {
                Console.WriteLine(jarmuvek[i].Rendszam + " bérletdíja " + jarmuvek[i].BerletiDij() + " Ft.");
            }

            }
        }
}
