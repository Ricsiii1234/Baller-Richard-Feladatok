using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Állatmenhely
{
    class Allat
    {
        // mezők

        public string nev { get; private set; }
        public int szuletesiEv { get; private set; }
        public int rajtSzam{ get; private set; }

        public int szepsegPont { get; private set; }
        public int viselkedesPont { get; private set; }

        private static int aktualisEv { get; set; }
        private static int korHatar { get; set; }

        // konstruktor
        public Allat(int rajtSzam, string nev, int szuletesiEv)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
            this.rajtSzam = rajtSzam;
        }

        // metódusok
        public int Kor()
        {
            return aktualisEv - szuletesiEv;
        }

        public virtual int PontSzam()
        {
            if (Kor() < korHatar)
            {
                return viselkedesPont * Kor() + szepsegPont * (korHatar - Kor());
            }
            return 0;
        }


        public void Pontozzak(int szepsegPont, int viselkedesPont)
        {
            this.szepsegPont = szepsegPont;
            this.viselkedesPont = viselkedesPont;
        }

        public override string ToString()
        {
            return rajtSzam + ". " + nev + " nevű" + this.GetType().Name.ToLower() + " pontszáma: " + PontSzam() + " pont.";
        }

        // Leszármaztatás

        class Kutya : Allat
        {
            public int GazdaViszonyPont { get; private set; }
            public bool KapottViszonyPont { get; private set; }

            public Kutya(int rajtSzam, string nev, int szuletesiEv) : base (rajtSzam, nev, szuletesiEv)
            {

            }

            public void ViszonPontozas(int gazdaViszonyPont)
            {
                this.GazdaViszonyPont = gazdaViszonyPont;
                KapottViszonyPont = true;
            }

            public override int PontSzam()
            {
                int pont = 0;
                if (KapottViszonyPont)
                {
                    pont = base.PontSzam() + GazdaViszonyPont;
                }
                return pont;
            }
        }

        class Macska : Allat
        {
            public bool VanMacskaSzallitoDoboz { get; set; }
            public Macska(int rajtSzam, string nev, int szuletesiEv, bool vanMacskaSzallitoDoboz) : base (rajtSzam, nev, szuletesiEv)
            {
                this.VanMacskaSzallitoDoboz = vanMacskaSzallitoDoboz;
            }

            public override int PontSzam()
            {
                if (VanMacskaSzallitoDoboz)
                {
                    return base.PontSzam();
                }
                return 0;
            }
        }

        class Vezerles
        {
            private List<Allat> allatok = new List<Allat>();

            public void Start()
            {
                Allat.AktualisEv = 2015;
                Allat.KorHatar = 10;
            }




            private void Proba()
            {
                Allat allat1, allat2;

                string nev1 = "Pamacs", nev2 = "Bolhazsák";
                int szuletesiEv1 = 2010, szuletesiEv2 = 2011;
                bool vanDoboz = true;
                int rajtSzam = 1;

                int szepsegPont = 5, viselkedePont = 4, viszonyPont = 6;

                allat1 = new Kutya(rajtSzam, nev1, szuletesiEv1);
                rajtSzam++;

                allat2 = new Macska(rajtSzam, nev2, szuletesiEv2, vanDoboz);

                Console.WriteLine("A regisztrált állatok: ");
                Console.WriteLine(allat1);
                Console.WriteLine(allat2);

                // verseny:
                allat2.Pontozzak(szepsegPont, viselkedePont);
                
                if (allat1 is Kutya)
                {
                    (allat1 as Kutya).ViszonPontozas(viszonyPont);
                }
                
                allat1.Pontozzak(szepsegPont, viselkedePont);
            }

            private void Regisztracio()
            {
                StreamReader olvasoCsatorna = new StreamReader("allatok.txt");

                string fajta, nev;
                int rajtSzam = 1, szuletesiEv;
                bool vanDoboz;

                // Olvasás a fájl végéig

                while (!olvasoCsatorna.EndOfStream)
                {
                    fajta = olvasoCsatorna.ReadLine();
                    nev = olvasoCsatorna.ReadLine();
                    szuletesiEv = int.Parse(olvasoCsatorna.ReadLine());

                    // Példányok létrehozása

                    if (fajta == "kutya")
                    {
                        allatok.Add(new Kutya(rajtSzam, nev, szuletesiEv));
                    }
                    else
                    {
                        vanDoboz = bool.Parse(olvasoCsatorna.ReadLine());
                        allatok.Add(new Macska(rajtSzam, nev, szuletesiEv, vanDoboz));
                    }
                    rajtSzam++;
                }
                olvasoCsatorna.Close();
            }

            private void Verseny()
            {
                Random rand = new Random();
                int hatar = 11;
                foreach (Allat item in allatok)
                {
                    if (item is Kutya)
                    {
                        (item as Kutya).ViszonPontozas(rand.Next(hatar));
                    }
                    item.Pontozzak(rand.Next(hatar) , rand.Next(hatar));
                }
            }

        }
        public int RajtSzam
        {
            get { return rajtSzam; }
            set { rajtSzam = value; }
        }

        // kívültről változtatható értékek

        public static int AktualisEv
        {
            get { return aktualisEv; }
            set { aktualisEv = value; }
        }
        public static int KorHatar
        {
            get { return korHatar; }
            set { korHatar = value; }
        }

        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            new Vezerles().Start();

            Console.ReadKey();
        }      
    }
}
