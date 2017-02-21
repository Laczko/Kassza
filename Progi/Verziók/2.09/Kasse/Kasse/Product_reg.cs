using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Kasse
{
    public partial class Product_reg : Alap
    {
        BindingSource bss = new BindingSource();
        AdatbázisQleDb alap = new AdatbázisQleDb();
        OleDbConnection MyConnection;
        DataSet DtSet;
        DataTable dt;
        OleDbDataAdapter MyCommand;
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range range;
        string Áfa;
        public Product_reg()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Betöltési hiba!");
            }
        }

        private void Mentes_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Szállítóikód();
                alap.Termékfelvitel(Vonalkod_text.Text, Gyorskod_text.Text, Termek_nev_text.Text, Szallito_text.Text, Szallito_kod_text.Text, Kategoria_text.Text, int.Parse(Mennyisegi_ar.Text), Mennyisegi_egyseg_text.Text + "/" + Mennyisegi_egyseg_comboBox.Text, Kiszereles_text.Text + "/" + Kiszereles_comboBox.Text, int.Parse(Eladási_ar_text.Text), double.Parse(Netto_ar_text.Text), double.Parse(Akcios_ar_text.Text), Datum_text.Value, Felnőttartalom.Checked, Áfa);
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Mentési hiba!");
            }

        }
        private void Szállítóikód()//Keresés listában Lista feltöltése
        {
            string kod = Vonalkod_text.Text;
            Szallito_kod_text.Text = kod.Substring(3, 7);//0-tól kezdődik

        }

        private void Afa(object sender, EventArgs e)
        {
            try
            {
                double eladás = int.Parse(Eladási_ar_text.Text);
                double x;
                double Netto;
                if (afa_27.Checked)
                {
                    x = (eladás / 1.27);
                    Netto = Math.Round(x, 2);
                    Netto_ar_text.Text = Netto.ToString();
                    Akcios_ar_text.Text = (eladás * 0.6).ToString();
                    Áfa = "C";
                }
                else if (afa_18.Checked)
                {
                    x = (eladás / 1.18);
                    Netto = Math.Round(x, 2);
                    Netto_ar_text.Text = Netto.ToString();
                    Akcios_ar_text.Text = (eladás * 0.6).ToString();
                    Áfa = "B";
                }
                else
                {
                    x = (eladás / 1.05);
                    Netto = Math.Round(x, 2);
                    Netto_ar_text.Text = Netto.ToString();
                    Akcios_ar_text.Text = (eladás * 0.6).ToString();
                    Áfa = "A";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Áfa kiválasztási hiba!");
            }

        }

        private void Szállító(object sender, EventArgs e)//Leave Event és Click event
        {
            Szállítóikód();
        }

        private void Fajl_betolto_button_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Minden fájl|*.xls;*.xlsx";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Fajl_eleres.Text = fd.FileName;
                string fajl_név = Fajl_eleres.Text;
                dt = new DataTable();
                MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + fajl_név +"';Extended Properties=Excel 8.0;");
                MyCommand = new OleDbDataAdapter("select * from [Munkalap1$]", MyConnection);//Munkalap változtatás kell!!
                //MyCommand.TableMappings.Add("Table", "TestTable");
                MyCommand.Fill(dt);
                bss.DataSource = dt;
                MessageBox.Show(Convert.ToString(dt));
                MyConnection.Close();               
            }
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            bss.MoveNext();
            //Lépés();
        }
        private void Lépés()
        {
            
            //Fajl_eleres.Text = fd.FileName;
            string fajl_név = Fajl_eleres.Text;
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            int rCnt = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(fajl_név, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;

            for (rCnt = 2; rCnt <= range.Rows.Count; )//Sor
            {
                Vonalkod_text.Text = Convert.ToString((range.Cells[rCnt, 1] as Excel.Range).Value2);
                Gyorskod_text.Text = Convert.ToString((range.Cells[rCnt, 2] as Excel.Range).Value2);
                Termek_nev_text.Text = Convert.ToString((range.Cells[rCnt, 3] as Excel.Range).Value2);
                Szallito_text.Text = Convert.ToString((range.Cells[rCnt, 4] as Excel.Range).Value2);
                Szallito_kod_text.Text = Convert.ToString((range.Cells[rCnt, 5] as Excel.Range).Value2);
                Kategoria_text.Text = Convert.ToString((range.Cells[rCnt, 6] as Excel.Range).Value2);
                Mennyisegi_ar.Text = Convert.ToString((range.Cells[rCnt, 7] as Excel.Range).Value2);
                Mennyisegi_egyseg_text.Text = Convert.ToString((range.Cells[rCnt, 8] as Excel.Range).Value2);
                Kiszereles_text.Text = Convert.ToString((range.Cells[rCnt, 9] as Excel.Range).Value2);
                Eladási_ar_text.Text = Convert.ToString((range.Cells[rCnt, 10] as Excel.Range).Value2);
                Netto_ar_text.Text = Convert.ToString((range.Cells[rCnt, 11] as Excel.Range).Value2);
                Akcios_ar_text.Text = Convert.ToString((range.Cells[rCnt, 12] as Excel.Range).Value2);
                break;
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

        }
    }
}
