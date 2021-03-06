﻿using System;
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
using System.IO;


namespace Kasse
{
    public partial class Product_reg : Alap
    {
        BindingSource bss = new BindingSource();
        AdatbázisQleDb alap = new AdatbázisQleDb();
        OleDbConnection MyConnection;
        DataTable dt;
        OleDbDataAdapter MyCommand;
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
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
                alap.Termékfelvitel(Vonalkod_text.Text, Gyorskod_text.Text, Termek_nev_text.Text, Szallito_text.Text, Szallito_kod_text.Text, Kategoria_text.Text, int.Parse(Mennyisegi_ar_text.Text), Mennyisegi_egyseg_text.Text + "/" + Mennyisegi_egyseg_comboBox.Text, Kiszereles_text.Text + "/" + Kiszereles_comboBox.Text, int.Parse(Eladási_ar_text.Text), double.Parse(Netto_ar_text.Text), double.Parse(Akcios_ar_text.Text), Datum_text.Value, Felnőttartalom.Checked, Áfa);
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
            List<string> Táblanév = new List<string>();
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Kimenet fájlok|Kimenet_*.xls;Kimenet_*.xlsx";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Fajl_eleres.Text = fd.FileName;
                string fajl_név = Fajl_eleres.Text;
                string fileExtension = Path.GetExtension(fajl_név);
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(fajl_név, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);//Munkalapok száma
                dt = new DataTable();
                if (fileExtension == ".xls")
                    MyConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fajl_név + ";" + "Extended Properties='Excel 8.0;HDR=YES;'");
                if (fileExtension == ".xlsx")
                    MyConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fajl_név + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'");
                MyCommand = new OleDbDataAdapter("select * from [" + xlWorkSheet.Name + "$]", MyConnection);//Munkalap beolvasása
                MyCommand.Fill(dt);
                bss.DataSource = dt;
                MyConnection.Close();
                foreach (DataColumn column in dt.Columns)
                {
                    if (column != null)
                    {
                        Táblanév.Add(column.ColumnName.ToString());
                        //MessageBox.Show(column.ColumnName.ToString());
                    }
                }
                Vonalkod_text.DataBindings.Add(new Binding("Text", bss, "Vonalkod"));
                Gyorskod_text.DataBindings.Add(new Binding("Text", bss, Táblanév[1]));
                Termek_nev_text.DataBindings.Add(new Binding("Text", bss, "Nev"));
                Szallito_text.DataBindings.Add(new Binding("Text",bss,"Szallito"));
                Szallito_kod_text.DataBindings.Add(new Binding("Text", bss, Táblanév[4]));
                Kategoria_text.DataBindings.Add(new Binding("Text", bss, "Kategoria"));
                Mennyisegi_ar_text.DataBindings.Add(new Binding("Text", bss, Táblanév[6]));
                Kiszereles_text.DataBindings.Add(new Binding("Text",bss, "Kiszereles"));
                Eladási_ar_text.DataBindings.Add(new Binding("Text", bss, "Eladasi_ar"));
                Netto_ar_text.DataBindings.Add(new Binding("Text", bss, Táblanév[8]));
                Akcios_ar_text.DataBindings.Add(new Binding("Text", bss, "Akcios_ar"));
                Datum_text.DataBindings.Add(new Binding("Value", bss, "Datum"));

                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
            }
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            bss.MoveNext();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            bss.MovePrevious();
        }
    }
}
