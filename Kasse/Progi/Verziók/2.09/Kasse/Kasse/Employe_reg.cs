using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasse
{
    public partial class Employe_reg : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        Random rnd = new Random();
        protected string Nev;
        public Employe_reg()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Betöltési hiba!");
            }
        }

        private void Employe_mentesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                alap.Tagfelvétel(Kodszam_text.Text, Tag_Nev_text.Text, Tag_jelszo_text.Text, Nev);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Mentési hiba!");
                Logger.Error("Mentési hiba!","Tagfelvétel");
            }

        }
        private void Radbutton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cash_radbutton.Checked)
                {
                    Kodszam_text.Text = rnd.Next(999, 1400).ToString();
                    Nev = Cash_radbutton.Text;
                }
                else if (Product_radbutton.Checked)
                {
                    Kodszam_text.Text = rnd.Next(1500, 2000).ToString();
                    Nev = Product_radbutton.Text;
                }
                else
                {
                    Kodszam_text.Text = rnd.Next(3500, 4000).ToString();
                    Nev = Gazd_radbutton.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Radbutton kiválasztási hiba!");
                Logger.Error("Munkaköri kiválasztási hiba!","Radbutton checked");
            }

        }
    }
}
