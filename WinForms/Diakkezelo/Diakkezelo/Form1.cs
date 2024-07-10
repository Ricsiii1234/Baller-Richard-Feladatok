using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diakkezelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
        }
        private void GombBeallitas(bool aktiv)
        {
            btnAdatBe.Enabled = !aktiv;
        }

        List<Diak> diakok = new List<Diak>();


        private void AdatBeolvasas(string fajlNev)
        {
            StreamReader sr = new StreamReader(fajlNev);

            string adat = sr.ReadLine();
            while (adat != null)
            {
                Feldolgoz(adat);
                adat = sr.ReadLine();
            }
            sr.Close();
        }

        private void lstEredmeny_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstEredmeny.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.SzuletesiEv;
        }

       
        List<int> evek = new List<int>();
        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            Diak diak;
            diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            lstDiakok.Items.Add(diak);
            if (!evek.Contains(diak.SzuletesiEv)) evek.Add(diak.SzuletesiEv);
        }

        private void FelrakDiakok()
        {
            for (int i = 0; i < diakok.Count; i++)
            {
                lstDiakok.Items.Add(diakok[i].ToString());
            }
        }

        private void Kivalaszt(object sender, EventArgs e)
        {
            int ev = int.Parse((sender as Button).Text);

            lstEredmeny.Items.Clear();
            foreach (Diak diak in lstDiakok.Items)
            {
                if (diak.SzuletesiEv == ev) lstEredmeny.Items.Add(diak);
            }
        }

        private void FelrakEvek()
        {
            Button btn;
            evek.Sort();
            for (int i = 0; i < evek.Count; i++)
            {
                btn = new Button();
                btn.Left = pnlEvek.AutoScrollPosition.X + 80 * pnlEvek.Controls.Count;
                btn.Text = evek[i].ToString();

                btn.Click += new System.EventHandler(Kivalaszt);

                pnlEvek.Controls.Add(btn);
            }
        }


        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    AdatBeolvasas(fajlNev);
                    FelrakDiakok();
                    FelrakEvek();
                    GombBeallitas(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        }
    }

    class Diak
    {
        public string Nev { get; private set; }
        public string Azonosito { get; private set; }
        public int SzuletesiEv { get; set; }

        public Diak(string nev, string azonosito, int ev)
        {
            Nev = nev;
            Azonosito = azonosito;
            this.SzuletesiEv = ev;
        }

        public override string ToString()
        {
            return Nev + ' ' + Azonosito;
        }
    }
}
