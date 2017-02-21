using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kasse
{
    public partial class Employe : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        public Employe()
        {
            InitializeComponent();
            Megjelenítő();
        }

        private void Employee_regbutton_Click(object sender, EventArgs e)
        {
            Employe_reg Felhasználó_reg = new Employe_reg();
            Felhasználó_reg.Show();

            //06-30/368-59-92 Pista száma
        }
        public void Megjelenítő()
        {
            alap.Alkamazottlekérdező(Alkalmazott_mutato);
            Alkalmazott_mutato.Refresh();
        }
    }
   
    }

