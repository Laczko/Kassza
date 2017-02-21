using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kasse
{
    public partial class Alap : Form
    {

        public AdatbázisQleDb odb;
        public Alap()
        {
            InitializeComponent();
            odb = AdatbázisQleDb.PeldanySzerez();
            odb.Kapcsolódás(Environment.CurrentDirectory + @"\Kasse.accdb");//Debug mappában lévő kassára mutat.

        }

        public class AdatbázisQleDb
        {
            protected DataSet ds;
            protected OleDbDataAdapter oda;
            protected DataTable dt;
            protected OleDbCommand oc;
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\Kasse.accdb" + ";");

            //Megkérdezni,hogy működik Singleton
            #region Singleton

            public AdatbázisQleDb()
            {
            }
            public static AdatbázisQleDb sajat;
            public static AdatbázisQleDb PeldanySzerez()
            {
                if (sajat == null) sajat = new AdatbázisQleDb();
                return sajat;
            }

            #endregion


            public bool Kapcsolódás(string Adatbázisfájl)
            {
                try
                {
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
                    Lekapcsolódás();
                }
            }
            public void Lekapcsolódás()
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            public string Login(int Kódszám, int Jelszó)
            {
                string Azonosito_nev;
                try
                {
                    // OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\Kasse.accdb" + ";");

                    conn.Open();
                    string lekérdezés = String.Format("Select Azonosito, Jelszo from Alkalmazott_reg where Azonosito = {0} and Jelszo = {1} ", Kódszám, Jelszó);
                    string névmegjelenítés = String.Format("Select Nev from Alkalmazott_reg where Azonosito = {0}", Kódszám);
                    ds = new DataSet();//Összes tábla megjelenítése
                    oc = new OleDbCommand(lekérdezés, conn);
                    OleDbDataReader odr;
                    odr = oc.ExecuteReader();//Adatkeresés
                    int count = 0;
                    while (odr.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        odr.Close();
                        oda = new OleDbDataAdapter(névmegjelenítés, conn);
                        oda.Fill(ds, "Alkalmazott_reg");
                        Azonosito_nev = ((string)ds.Tables[0].Rows[0]["Nev"]);
                        return Azonosito_nev;
                    }
                    else if (count > 0)
                    {
                        MessageBox.Show("Dupla jelszó vagy felhasználónév");
                    }
                    else
                    {
                        MessageBox.Show("Felhasználó név vagy jelszó rossz");
                    }

                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                return "Nincs ilyen felhasználó név!";
            }
            public string Beosztas(string Kódszám)
            {
                string beosztas;
                try
                {
                    string munkakor = String.Format("Select Beosztas from Alkalmazott_reg where Azonosito = {0}", Kódszám);
                    oda = new OleDbDataAdapter(munkakor, conn);
                    ds = new DataSet();
                    oda.Fill(ds, "Alkalmazott_reg");
                    beosztas = ((string)ds.Tables[0].Rows[0]["Beosztas"]);
                    return beosztas;
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                return "";
            }
            public void Alkamazottlekérdező(DataGridView Megjelenito)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("Select * from Alkalmazott_reg");
                    oda = new OleDbDataAdapter(query,conn);
                    dt = new DataTable();
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dt;
                    oda.Fill(dt);
                    Megjelenito.DataSource = dt;
                    oda.Update(dt);
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }
            }
            public void SzámlaMegtekintő(DataGridView Megjelenito)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("Select * from Számla_reg");
                    oda = new OleDbDataAdapter(query, conn);
                    dt = new DataTable();
                    oda.Fill(dt);
                    Megjelenito.DataSource = dt;
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }
            }
            public void Termékmegtekintő(DataGridView Megjelenito)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("Select * from Termek_reg");
                    oda = new OleDbDataAdapter(query, conn);
                    dt = new DataTable();
                    oda.Fill(dt);
                    Megjelenito.DataSource = dt;
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }
            }
            public void Tagfelvétel(string kódszám, string Név, string jelszo,string Beosztas)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("INSERT INTO Alkalmazott_reg (Azonosito,Nev,Jelszo,Beosztas) VALUES ('{0}', '{1}', '{2}', '{3}')", kódszám, Név, jelszo,Beosztas);
                    oda = new OleDbDataAdapter(query, conn);
                    ds = new DataSet();
                    oda.Fill(ds);
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }
            }
            public void Termékfelvitel(string Vonalkod, string Gyorskód,string Név, string Szállító, string Kategória, string Menny_érték, string Menny_egység, string Eladási_ár, string Nettó, string Akció, DateTime dateTime, bool Felnőt,string Áfa)
            {
                try
                {
                    conn.Open();//Insert Into szintaktikai hiba, datetime átadás.
                    string query = String.Format("Insert Into Termek_reg Values ('{0}', '{1}', '{2}', '{3}', '{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'", Vonalkod,Gyorskód, Név, Szállító, Kategória, Menny_érték, Menny_egység, Eladási_ár, Nettó, Akció, dateTime.Date.ToString("yyyy-MM-dd HH:mm:ss"), Felnőt,Áfa);
                    oda = new OleDbDataAdapter(query, conn);
                    ds = new DataSet();
                    oda.Fill(ds);
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }
                
            }
            public string Terkmékkereső(string Termékkód,string Megjelenito)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("Select Nev,Eladasi_ar,Áfa from Termek_reg where Vonalkod ={0} or Gyorskód = {0}", Termékkód);
                    oc = new OleDbCommand(query, conn);
                    return Megjelenito = oc.CommandText;
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); } 
                return "";
            }
        }
    }
}
