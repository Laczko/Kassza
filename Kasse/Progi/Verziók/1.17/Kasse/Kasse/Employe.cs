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
using System.Web;

namespace Kasse
{
    public partial class Employe : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        Employe_reg alkalmazott = (Employe_reg)Application.OpenForms["Employe_reg"];
        public Employe()
        {
            InitializeComponent();
            Megjelenítő();
        }

        private void Employee_regbutton_Click(object sender, EventArgs e)
        {
            Employe_reg Felhasználó_reg = new Employe_reg();
            Felhasználó_reg.Show();
        }
        public void Megjelenítő()
        {
            alap.Alkamazottlekérdező(Alkalmazott_mutato);
        }

        private void Employee_updatebutton_Click(object sender, EventArgs e)
        {

            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in Alkalmazott_mutato.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null) //Ha ki van választva egy sor
            {
                DataGridViewRow data = cell.OwningRow;
                string query = String.Format("UPDATE Alkalmazott_reg SET Azonosito={1},Nev='{2}',Jelszo={3},Beosztas='{4}' WHERE Id={0}", data.Cells[0].Value, data.Cells[1].Value, data.Cells[2].Value, data.Cells[3].Value, data.Cells[4].Value);//mindent amit a tömbből kiolvas, módosítja az adatbázisban
                alap.Módosítás(query);
            }
            Megjelenítő();
        }


        private void Employee_deletebutton_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in Alkalmazott_mutato.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null) //Ha ki van választva egy sor
            {
                DataGridViewRow data = cell.OwningRow;
                string query = String.Format("DELETE FROM Alkalmazott_reg WHERE Id={0}", data.Cells[0].Value);//törli az adott rekordot, az elsődleges kulcs alapján
                alap.Módosítás(query);
            }
            Megjelenítő();
        }

        private void Employee_frissitesbutton_Click(object sender, EventArgs e)
        {
            Megjelenítő();
        }
    }
   
    }

