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
        public Employe()
        {
            try
            {
                InitializeComponent();
                Megjelenítő();
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Betöltési hiba!");
            }
        }

        private void Employee_regbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Employe_reg Felhasználó_reg = new Employe_reg();
                Felhasználó_reg.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Regisztációs felület megjelenési hiba!");
                Logger.Error("Regisztációs felület megjelenési hiba!", "Alkalmazott regisztráció");
            }
        }

        public void Megjelenítő()
        {
            try
            {

                alap.Alkamazottlekérdező(Alkalmazott_mutato);
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Megjeleítő() hiba!");
                Logger.Error("Megjeleítő hiba","Megjelenítő függvény");
            }
        }

        private void Employee_updatebutton_Click(object sender, EventArgs e)
        {
            try
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
                    alap.SqlParancs(query);
                    Logger.Info(query,"Alkalmazott módosítás");
                }
                Megjelenítő();
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Frissítési hiba!");
                Logger.Error("Módosítás hiba!","Alkalmazott reg módosítás");
            }

        }


        private void Employee_deletebutton_Click(object sender, EventArgs e)
        {
            try
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
                    alap.SqlParancs(query);
                    Logger.Info(query,"Alkalmazott törlése!");
                }
                Megjelenítő();
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Törlési hiba!");
                Logger.Error("Törlési hiba!", "Alkalmazott reg felület!");
            }

        }

        private void Employee_frissitesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Megjelenítő();
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Frissítési hiba!");
                Logger.Error("Frissítési hiba!", "Alkalmazott frissítés");
            }

        }
    }

}

