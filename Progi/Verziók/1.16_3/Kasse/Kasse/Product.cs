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

        public void Megjelenítő()
        {
            alap.Termékmegtekintő(Termek_mutato);
        }

        private void Termek_regbutton_Click(object sender, EventArgs e)
        {
            Product_reg Termék_reg = new Product_reg();
            Termék_reg.Show();
        }

        private void Termek_updatebutton_Click(object sender, EventArgs e)
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
                string query = String.Format("UPDATE Termék_reg SET Vonalkod='{1}',Gyorskód={2},Nev='{3}',Szallito='{4}',Kategoria='{5}',Mennyiseg_ertek={6},Mennyisegi_egyseg='{7}',Eladasi_ar={8},Netto_ar={9},Akcios_ar={10},Datum={11},Felnot_tartalmu={12},Áfa={13} WHERE Id={0}", data.Cells[0].Value, data.Cells[1].Value, data.Cells[2].Value, data.Cells[3].Value, data.Cells[4].Value, data.Cells[5].Value, data.Cells[6].Value, data.Cells[7].Value, data.Cells[8].Value, data.Cells[9].Value, data.Cells[10].Value, data.Cells[11].Value, data.Cells[12].Value, data.Cells[13].Value);//mindent amit a tömbből kiolvas, módosítja az adatbázisban
                alap.Módosítás(query);
            }
            Megjelenítő();
        }

        private void Termek_deletebutton_Click(object sender, EventArgs e)
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
                string query = String.Format("DELETE FROM Termék_reg WHERE Id={0}", data.Cells[0].Value);//mindent amit a tömbből kiolvas, módosítja az adatbázisban
                alap.Módosítás(query);
            }
            Megjelenítő();
        }

        private void Termek_frissitesbutton_Click(object sender, EventArgs e)
        {
            Megjelenítő();
        }


    }
}
