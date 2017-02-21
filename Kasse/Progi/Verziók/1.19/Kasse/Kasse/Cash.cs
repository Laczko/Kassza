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
            label1.Text = "Tétel:";
            for (int i = 0; i < x; i++)
            {
                Termek_lista.AddRange(T.Terkmékkereső(Tetel_input.Text));
                termekek_listBox1.Items.Add(Termek_lista[Termek_lista.Count - 1]);
            }

            x = 1;
            Fizetendotext.Text = T.Osszead(Termek_lista).ToString();
            Tetelszamlalotext.Text = Termek_lista.Count.ToString();
            
        }
        

        private void Torles_button10_Click(object sender, EventArgs e)
        {
            Termekek T = new Termekek();
            Termek_lista.RemoveAt(termekek_listBox1.SelectedIndex);
            termekek_listBox1.Items.Remove(termekek_listBox1.SelectedItem);
            Fizetendotext.Text = T.Osszead(Termek_lista).ToString();
            Tetelszamlalotext.Text = Termek_lista.Count.ToString();
        }

        static int x=1;
        private void buttonX_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(Tetel_input.Text);
            label1.Text = x.ToString();
            Tetel_input.Clear();
        }

        private void KP_button_Click(object sender, EventArgs e)
        {
            Termekek T = new Termekek();
            fizetett_textBox.Text= T.kerekit(Convert.ToInt32(Fizetendotext.Text)).ToString();
        }

        private void Card_button_Click(object sender, EventArgs e)
        {
            fizetett_textBox.Text = Fizetendotext.Text;
        }

        private void uj_button_Click(object sender, EventArgs e)
        {
            Termek_lista.Clear();
            termekek_listBox1.Items.Clear();
            Fizetendotext.Clear();
            Tetelszamlalotext.Clear();
            Tetel_input.Clear();
            x = 1;
            fizetett_textBox.Clear();
            visszajaro_textBox.Clear();
        }

        private void Igen_Enter_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
