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
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
            textBox1.Text = "Hello" + Environment.NewLine+"Szia!";
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
    }
}
