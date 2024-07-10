using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatekadatumokkal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IbIDatum_Click(object sender, EventArgs e)
        { }

        private DateTime ma = DateTime.Now;
        private DateTime szulDatum;
        private DateTime valasztottDatum;

        private void Form1_Load(object sender, EventArgs e)
        {
            IbIDatum.Text = ma.ToString("F");
            IbIGratulacio.Text = "";
            valasztottDatum = dateTimePicker1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IbIDatum.Text = DateTime.Now.ToString("F");
        }

        private void btnKiir_Click(object sender, EventArgs e)
        {
            txtEvSzam.Text = (ma.Year - szulDatum.Year).ToString();
            txtNap.Text = szulDatum.DayOfWeek.ToString();
            txtNapSorszam.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            valasztottDatum = dateTimePicker1.Value;
            txtNapSorszam.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void txtNapSzam_TextChanged(object sender, EventArgs e)
        {
            int hossz = txtNapSzam.Text.Length;
            if ((hossz >= 2 && txtNapSzam.Text.ElementAt(0) == '-') ||
                (hossz >= 1 && txtNapSzam.Text.ElementAt(0) != '-'))
            {
                try
                {
                    int nap = int.Parse(txtNapSzam.Text);
                    txtKesobbiDatum.Text = valasztottDatum.AddDays(nap).ToString("d");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem számot írt", "Hiba");
                }
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();
            }
            IbIGratulacio.Text = "";
            mskdTxtSzulDatum.Clear();
        }

        private void btnBezár_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!mskdTxtSzulDatum.MaskCompleted) throw new FormatException();
                else
                {
                    szulDatum = DateTime.Parse(mskdTxtSzulDatum.Text);
                    if (szulDatum.Month == ma.Month && szulDatum.Day == ma.Day)
                    {
                        IbIGratulacio.Text = "Isten éltessen!";
                    }
                    else
                    {
                        IbIGratulacio.Text = "Boldog hétköznapot!";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hibás dátum", "Hiba");
            }
        }

        private void mskdTxtSzulDatum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                if (!mskdTxtSzulDatum.MaskCompleted) throw new FormatException();
                else
                {
                    szulDatum = DateTime.Parse(mskdTxtSzulDatum.Text);
                    if (szulDatum.Month == ma.Month && szulDatum.Day == ma.Day)
                    {
                        IbIGratulacio.Text = "Isten éltessen!";
                    }
                    else
                    {
                        IbIGratulacio.Text = "Boldog hétköznapot!";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hibás dátum", "Hiba");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Gratulacio();
        }

        private void Gratulacio()
        {
            try
            {
                if (!mskdTxtSzulDatum.MaskCompleted) throw new FormatException();
                else
                {
                    szulDatum = DateTime.Parse(mskdTxtSzulDatum.Text);
                    if (szulDatum.Month == ma.Month && szulDatum.Day == ma.Day)
                    {
                        IbIGratulacio.Text = "Isten éltessen!";
                    }
                    else
                    {
                        IbIGratulacio.Text = "Boldog hétköznapot!";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hibás dátum", "Hiba");
                mskdTxtSzulDatum.Focus();
            }
        }
    }
}
