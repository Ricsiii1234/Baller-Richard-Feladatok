using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dalverseny
{
    class Versenyzo
    {
        // mezők

        private int rajtSzam;
        private string nev;
        private string szak;
        private int pontSzam;

        // konstruktor
        public Versenyzo(int rajtSzam, string nev, string szak)
        {
            this.rajtSzam = rajtSzam;
            this.nev = nev;
            this.szak = szak;
        }

        // metódusok

        public void PontotKap(int pont)
        {
            pontSzam += pont;
        }

        public override string ToString()
        {
            return rajtSzam + "\t" + nev + "\t" + szak + "\t" + pontSzam + " pont";
        }

        // tulajdonságok

        public int RajtSzam
        {
            get { return rajtSzam; }
        }

        public string Nev
        {
            get { return nev; }
        }

        public string Szak
        {
            get { return szak; }
        }

        public int PontSzam
        {
            get { return pontSzam; }
        }

        //---------------------------

        
    }

    class VezerloOsztaly
    {
        private List<Versenyzo> versenyzok = new List<Versenyzo>();

        public void Start()
        {
            AdatBevitel();

            Kiiratas("\nRésztvevők:\n");
            Verseny();
            Kiiratas("\nEredmények:\n");

            Keresesek();

            Nyertes();
            Sorrend();
        }

        public void AdatBevitel()
        {
            Versenyzo versenyzo;
            string nev, szak;
            int sorszam = 1;

            StreamReader olvasoCsatorna = new StreamReader("versenyzok.txt");

            while (!olvasoCsatorna.EndOfStream)
            {
                nev = olvasoCsatorna.ReadLine();
                szak = olvasoCsatorna.ReadLine();

                // versenyző példány létrehozása
                versenyzo = new Versenyzo(sorszam, nev, szak);

                // listához adjuk az adott versenyzőt
                versenyzok.Add(versenyzo);


                sorszam++;
            }

            olvasoCsatorna.Close();
        }

        private void Kiiratas(string cim)
        {
            Console.WriteLine(cim);
            foreach (Versenyzo enekes in versenyzok)
            {
                Console.WriteLine(enekes);
            }
        }

        private int zsuriLetszam = 5;
        private int pontHatar = 10;


        private void Verseny()
        {
            Random rand = new Random();
            int pont;
            foreach (Versenyzo versenyzo in versenyzok)
            {
                // zsűri pontozása

                for (int i = 0; i < zsuriLetszam; i++)
                {
                    pont = rand.Next(pontHatar);
                    versenyzo.PontotKap(pont);
                }
            }
        }

        private void Nyertes()
        {
            // Kezdőérték

            int max = versenyzok[0].PontSzam;

            // a legnagyobb érték megállapítása

            foreach (Versenyzo enekes in versenyzok)
            {
                if (enekes.PontSzam > max)
                {
                    max = enekes.PontSzam;
                }
            }

            // legjobbak kiíratása

            Console.WriteLine("\nA legjobb(ak):\n");
            foreach (Versenyzo enekes in versenyzok)
            {
                if (enekes.PontSzam == max)
                {
                    Console.WriteLine(enekes);
                }
            }
        }

        private void Sorrend()
        {
            // rendezés

            Versenyzo temp;

            for (int i = 0; i < versenyzok.Count() - 1; i++)
            {
                for (int j = 0; j < versenyzok.Count(); j++)
                {
                    if (versenyzok[i].PontSzam < versenyzok[j].PontSzam)
                    {
                        temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }

            Kiiratas("\nEredménytábla\n");
        }

        private void Keresesek()
        {
            Console.WriteLine("\nAdott szakhoz tartozó énekesek keresése\n");
            Console.Write("\nKerese valakit? (i/n)");
            char valasz;
            while (!char.TryParse(Console.ReadLine(), out valasz))
            {
                Console.Write("Egy karaktert írjon. ");
            }

            string szak;
            bool vanIlyen;

            while (valasz == 'i' || valasz == 'I')
            {
                Console.Write("Szak: ");
                szak = Console.ReadLine();
                vanIlyen = false;

                foreach (Versenyzo enekes in versenyzok)
                {
                    if (enekes.Szak == szak)
                    {
                        Console.WriteLine(enekes);
                        vanIlyen = true;
                    }
                }

                if (!vanIlyen)
                {
                    Console.WriteLine("Erről a szakrol senki sem indult.");
                }

                Console.Write("\nKeres még valakit? (i/n)");
                valasz = char.Parse(Console.ReadLine());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new VezerloOsztaly().Start();

            Console.ReadKey();
        }
    }
}
