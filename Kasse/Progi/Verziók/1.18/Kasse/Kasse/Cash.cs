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
    public partial class Cash : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        List<Termekek> Termek_lista = new List<Termekek>();
        public Cash()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                int gs = int.Parse(((Button)sender).Text);
                //if (vonalkod_be_e == true)
                {
                    Tetel_input.Text += ((Button)sender).Text;
                }
                /*else
                {
                    fizetett_be.Text += ((Button)sender).Text;
                }*/
            }
            catch
            {
                //this.edited_input_delete_last_char();
            }
        }

        private void Igen_Enter_Click(object sender, EventArgs e)
        {
            Termekek T = new Termekek();

            Termek_lista.AddRange(T.Terkmékkereső(Tetel_input.Text));
            Fizetendotext.Text = T.Osszead(Termek_lista).ToString();
            Tetelszamlalotext.Text = Termek_lista.Count.ToString();
            termekek_listBox1.Items.Add(Termek_lista[Termek_lista.Count - 1]);
        }

    }
}
