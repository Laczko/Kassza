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
    public partial class Product : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        public Product()
        {
            InitializeComponent();
            alap.Termékmegtekintő(Termek_mutato);
        }

        private void Termek_regbutton_Click(object sender, EventArgs e)
        {
            Product_reg Termék_reg = new Product_reg();
            Termék_reg.Show();
        }
    }
}
