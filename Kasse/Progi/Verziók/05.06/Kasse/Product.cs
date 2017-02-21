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
        //AdatbázisQleDb alap = new AdatbázisQleDb();
        AdatbázisOracle orac = new AdatbázisOracle();
        public Product()
        {
            try
            {
                InitializeComponent();
                orac.Termékmegtekintő(Termek_mutato);
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Betöltési hiba!");
            }
        }

        public void Megjelenítő()
        {
            try
            {
                orac.Termékmegtekintő(Termek_mutato);
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Megjelenítő() hiba!");
            }

        }

        private void Termek_regbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Product_reg Termék_reg = new Product_reg();
                Termék_reg.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Termékregisztrációs hiba!");
            }

        }

        private void Termek_updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in Termek_mutato.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null) //Ha ki van választva egy sor
                {
                    DataGridViewRow data = cell.OwningRow;
                    string query = String.Format("UPDATE Termek_reg SET Vonalkod='{1}',Gyorskód={2},Nev='{3}',Szallito='{4}',Kategoria='{5}',Mennyiseg_ertek={6},Mennyisegi_egyseg='{7}',Eladasi_ar={8},Netto_ar='{9}',Akcios_ar={10},Datum='{11}',Felnot_tartalmu={12},Áfa='{13}' WHERE Id={0}", data.Cells[0].Value, data.Cells[1].Value, data.Cells[2].Value, data.Cells[3].Value, data.Cells[4].Value, data.Cells[5].Value, data.Cells[6].Value, data.Cells[7].Value, data.Cells[8].Value, data.Cells[9].Value, data.Cells[10].Value, data.Cells[11].Value, data.Cells[12].Value, data.Cells[13].Value);//mindent amit a tömbből kiolvas, módosítja az adatbázisban
                    orac.SqlParancs(query);
                }
                Megjelenítő();
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Termékfrissítési hiba!");
            }

        }

        private void Termek_deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in Termek_mutato.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null) //Ha ki van választva egy sor
                {
                    DataGridViewRow data = cell.OwningRow;
                    string query = String.Format("DELETE FROM Termek_reg WHERE Id={0}", data.Cells[0].Value);//Törli az adott rekordot az elsődleges kulcs alapján
                    orac.SqlParancs(query);
                }
                Megjelenítő();
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Terméktörlési hiba!");
            }
        }

        private void Termek_frissitesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Megjelenítő();
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Termékfrissítési hiba!");
            }
        }
    }
}
