using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kasse
{
    public partial class Alap : Form
    {

        public AdatbázisQleDb odb;
        // static public bool kapcs;
        public Alap()
        {
            InitializeComponent();
            odb = AdatbázisQleDb.PeldanySzerez();
            odb.Kapcsolódás(Environment.CurrentDirectory + @"\Kasse.accdb");//Debug mappában lévő kassára mutat.

        }
        public class AdatbázisQleDb
        {
            protected OleDbConnection conn;
            protected DataSet ds;
            protected OleDbDataAdapter oda;

            //Megkérdezni,hogy működik Singleton
            #region Singleton

            private AdatbázisQleDb() { }
            private static AdatbázisQleDb sajat;
            public static AdatbázisQleDb PeldanySzerez()
            {
                if (sajat == null) sajat = new AdatbázisQleDb();
                return sajat;
            }

            #endregion


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
                /*finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }*/
            }




            public string Login(int Kódszám, int Jelszó)
            {
                string Azonosito_nev;
                try
                {
                    conn.Open();
                    string lekérdezés = String.Format("Select Azonosito, Jelszo from Alkalmazott_reg where Azonosito = {0} and Jelszo = {1} ", Kódszám, Jelszó);
                    //oda = new OleDbDataAdapter(lekérdezés, conn);
                    string névmegjelenítés = String.Format("Select Nev from Alkalmazott_reg where Azonosito = {0}", Kódszám);
                    //OleDbDataAdapter odb = new OleDbDataAdapter(névmegjelenítés, conn);
                    ds = new DataSet();//Összes tábla megjelenítése
                    OleDbCommand oc = new OleDbCommand(lekérdezés, conn);
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
        }
    }
}
