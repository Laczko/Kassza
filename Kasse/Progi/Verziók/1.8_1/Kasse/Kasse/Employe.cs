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
        //private AdatbázisQleDb odb;
        public Employe():base()
        {
            InitializeComponent();
            //odb = AdatbázisQleDb.PeldanySzerez();
            //odb.Kapcsolódás(Environment.CurrentDirectory + @"\Kasse.accdb");
        }

        private void Employee_regbutton_Click(object sender, EventArgs e)
        {
            Employe_reg Felhasználó_reg = new Employe_reg();
            Felhasználó_reg.Show();
        }
        /*private void Alkamazottlekérdező(DataGridView Megjelenito)
        {
            try
            {
                conn.Open();
                string query = String.Format("select tagid,nev,cim,telefonszam,email from {0}", conn);
                da = new OleDbDataAdapter(query, conn);
                dt = new DataTable();
                da.Fill(dt);
                Megjelenito.DataSource = dt;
            }
            catch (OleDbException ode) { MessageBox.Show(ode.Message); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }
    }
    /*class AdatbázisQleDb
    {
        private OleDbConnection conn;
        private DataSet ds;
        private OleDbDataAdapter oda;

        //private AdatbázisQleDb();
        private static AdatbázisQleDb sajat;
        public static AdatbázisQleDb PeldanySzerez()
        {
            if (sajat == null) sajat = new AdatbázisQleDb();
            return sajat;
        }


        public bool Kapcsolódás(string Adatbázisfájl)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Adatbázisfájl + ";";
            try
            {
                conn = new OleDbConnection(connectionString);
                conn.Open();
                return true;
            }
            catch (OleDbException ode)
            {

                MessageBox.Show(ode.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }*/
    }
}
