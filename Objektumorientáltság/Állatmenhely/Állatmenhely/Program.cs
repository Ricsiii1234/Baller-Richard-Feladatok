using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Állatmenhely
{
    class Allat
    {
        // mezők

        private string nev;
        private int szuletesiEv;

        private int szepsegPont, viselkedesPont;
        private int pontSzam;

        private static int aktualisEv;
        private static int korHatar;

        // konstruktor
        public Allat(string nev, int szuletesiEv)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
        }

        // metódusok
        public int Kor()
        {
            return aktualisEv - szuletesiEv;
        }

        public void Pontozzak(int szepsegPont, int viselkedesPont)
        {
            this.szepsegPont = szepsegPont;
            this.viselkedesPont = viselkedesPont;
            if (Kor() <= korHatar)
            {
                pontSzam = viselkedesPont * Kor() + szepsegPont * (korHatar - Kor());
            }
            else
            {
                pontSzam = 0;
            }
        }

        public override string ToString()
        {
            return nev + " pontszáma: " + pontSzam + " pont";
        }

        // Tulajdonságok

        // Kivülről nem változtatható értékek

        public string Nev
        {
            get { return nev; }
        }
        public int SzuletesiEv
        {
            get { return szuletesiEv; }
        }
        public int SzepsegPont
        {
            get { return szepsegPont; }
        }
        public int ViselkedesPont
        {
            get { return viselkedesPont; }
        }
        public int PontSzam
        {
            get { return pontSzam; }
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

        class Program
        {
            static void Main(string[] args)
            {
                Allat allat;

                int aktEv = 2015, korhatar = 10;
                string nev;
                int szulEv;
                int szepseg, viselkedes;

                // Az aktuális év és a korhatár megadása

                Allat.AktualisEv = aktEv;
                Allat.KorHatar = korhatar;

                // csak egyetlen példány kipróbálása:

                nev = "Mirmur";
                szulEv = 2010;
                szepseg = 10;
                viselkedes = 8;

                // Az allat példány létrehozása 

                allat = new Allat(nev, szulEv);

                // a pontozási metódus meghívása

                allat.Pontozzak(szepseg, viselkedes);

                Console.WriteLine(allat);
                Console.ReadKey();
            }
        }
    }
}
