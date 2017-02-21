using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kasse
{
    public partial class Product_reg : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        string Áfa;
        public Product_reg()
        {
            InitializeComponent();
        }

        private void Mentes_Button_Click(object sender, EventArgs e)
        {
            alap.Termékfelvitel(Vonalkod_text.Text, Gyorskod_text.Text, Termek_nev_text.Text, Szallito_text.Text, Kategoria_text.Text, int.Parse(Mennyisegi_ertek.Text), Mennyisegi_egyseg_text.Text, int.Parse(Eladási_ar_text.Text), double.Parse(Netto_ar_text.Text), double.Parse(Akcios_ar_text.Text), Datum_text.Value, Felnőttartalom.Checked, Áfa);
            this.Close();
        }

        private void Afa(object sender, EventArgs e)
        {
            double eladás = int.Parse(Eladási_ar_text.Text);
            double x;
            double Netto;
            if (afa_27.Checked)
            {
                x = (eladás / 1.27);
                Netto = Math.Round(x, 2);
                Netto_ar_text.Text = Netto.ToString();
                Akcios_ar_text.Text = (eladás * 0.6).ToString();
                Áfa = "C";
            }
            else if (afa_18.Checked)
            {
                x = (eladás / 1.18);
                Netto = Math.Round(x, 2);
                Netto_ar_text.Text = Netto.ToString();
                Akcios_ar_text.Text = (eladás * 0.6).ToString();
                Áfa = "B";
            }
            else
            {
                x = (eladás / 1.05);
                Netto = Math.Round(x, 2);
                Netto_ar_text.Text = Netto.ToString();
                Akcios_ar_text.Text = (eladás * 0.6).ToString();
                Áfa = "A";
            }
        }
    }
}
