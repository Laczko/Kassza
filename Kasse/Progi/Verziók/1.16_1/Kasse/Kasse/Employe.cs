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
        Employe_reg alkalmazott = (Employe_reg)Application.OpenForms["Employe_reg"];
        public Employe()
        {
            InitializeComponent();
            Frissítés();
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
            Alkalmazott_mutato.Update();
            Alkalmazott_mutato.Refresh();
        }
        public void Frissítés()
        {
            Alkalmazott_mutato.Update();
            Alkalmazott_mutato.Refresh();
        }
    }
   
    }

