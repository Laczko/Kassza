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
    public partial class Account : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        public Account()
        {
            InitializeComponent();
            alap.SzámlaMegtekintő(Szamla_mutato);
        }

        private void Account_regbutton_Click(object sender, EventArgs e)
        {
            Account_reg Számla_reg = new Account_reg();
            Számla_reg.Show();
        }
    }
}
