﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Generic;

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
                    oda = new OleDbDataAdapter(query, conn);
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
            public void Tagfelvétel(string kódszám, string Név, string jelszo, string Beosztas)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("INSERT INTO Alkalmazott_reg (Azonosito,Nev,Jelszo,Beosztas) VALUES ('{0}', '{1}', '{2}', '{3}')", kódszám, Név, jelszo, Beosztas);
                    oda = new OleDbDataAdapter(query, conn);
                    ds = new DataSet();
                    oda.Fill(ds);
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }
            }
            public void Termékfelvitel(string Vonalkod, string Gyorskód, string Név, string Szállító, string Kategória, int Menny_érték, string Menny_egység, int Eladási_ár, double Nettó, double Akció, DateTime datum, bool Felnőt, string Áfa)
            {
                try
                {
                    conn.Open();
                    if (Gyorskód == "")
                    {
                        Gyorskód = "0";
                    }
                    string query = String.Format("INSERT INTO Termek_reg (Vonalkod, Gyorskód, Nev, Szallito, Kategoria, Mennyiseg_ertek, Mennyisegi_egyseg, Eladasi_ar, Netto_ar, Akcios_ar, Datum, Felnot_tartalmu, Áfa) VALUES ('{0}',{1},'{2}','{3}','{4}',{5},'{6}',{7},'{8}',{9},'{10}',{11},'{12}');", Vonalkod, Convert.ToInt32(Gyorskód), Név, Szállító, Kategória, Menny_érték, Menny_egység, Convert.ToInt32(Eladási_ár), Convert.ToInt32(Nettó), Convert.ToInt32(Akció), Convert.ToString(datum), Convert.ToString(Felnőt), Áfa);
                    oda = new OleDbDataAdapter(query, conn);
                    ds = new DataSet();
                    oda.Fill(ds);
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }

            }
            public string Terkmékkereső(string Termékkód, string terméknév, ref string ára, ref string áfa)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("Select Nev,Eladasi_ar,Áfa from Termek_reg where Vonalkod ='{0}'", Termékkód);// or Gyorskód = '{0}'
                    oc = new OleDbCommand(query, conn);
                    OleDbDataReader odr;
                    odr = oc.ExecuteReader();//Adatkeresés
                    while (odr.Read())
                    {
                        //Call Read to move to next record returned by SQL
                        //OR call --While(reader.Read())
                        terméknév = odr[0].ToString();
                        ára = odr[1].ToString();
                        áfa = odr[2].ToString();
                        odr.Close();
                        return terméknév;
                    }
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }
                return "";
            }

            public void Módosítás(string SQLParancs)
            {
                try
                {
                    conn.Open();
                    oda = new OleDbDataAdapter(SQLParancs, conn);
                    ds = new DataSet();
                    oda.Fill(ds);

                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }
            }

        }
    }

    public class Termekek
    {
        protected OleDbCommand oc;
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\Kasse.accdb" + ";");


        private string nev;
        private string ár;
        private string áfa;

        protected string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                nev = value;
            }
        }

        protected string Ár
        {
            get
            {
                return ár;
            }

            set
            {
                ár = value;
            }
        }

        protected string Áfa
        {
            get
            {
                return áfa;
            }

            set
            {
                áfa = value;
            }
        }


        public List<Termekek> Terkmékkereső(string Termékkód)
        {
            Alap.AdatbázisQleDb AB = new Alap.AdatbázisQleDb();
            List<Termekek> LISTA = new List<Termekek>();
            try
            {

                conn.Open();
                string query = String.Format("Select Nev,Eladasi_ar,Áfa from Termek_reg where Vonalkod ='{0}'", Termékkód);// or Gyorskód = '{0}'
                oc = new OleDbCommand(query, conn);
                OleDbDataReader odr;
                odr = oc.ExecuteReader();//Adatkeresés
                while (odr.Read())
                {
                    Termekek T = new Termekek();
                    T.Nev = odr[0].ToString();
                    T.Ár = odr[1].ToString();
                    T.Áfa = odr[2].ToString();
                    odr.Close();
                    LISTA.Add(T);
                    return LISTA;
                }
            }
            catch (OleDbException ode) { MessageBox.Show(ode.Message); }
            finally { conn.Close(); }
            return LISTA;
        }

        public double Osszead(List<Termekek> árak)
        {
            double osszeg = 0;
            for (int i = 0; i < árak.Count; i++)
            {
                osszeg = osszeg + Convert.ToDouble(árak[i].ár);
            }
            return osszeg;
        }

        /// <summary>
        /// Kerekítés szabályainak megfelelően kerekíti a bemeneti összeget
        /// </summary>
        /// <param name="bemenet">Bemeneti összeg</param>
        /// <returns>Kerekített kimenet</returns>
        public double kerekit(int bemenet)
        {
            double kimenet = bemenet;
            double maradek = bemenet % 10;
            if (maradek >= 8) kimenet += (10 - maradek);
            else if (maradek >= 6 && maradek <= 7) kimenet -= (maradek - 5);
            else if (maradek >= 3 && maradek <= 4) kimenet += (5 - maradek);
            else if (maradek >= 1 && maradek <= 2) kimenet -= maradek;
            return kimenet;
        }

        public override string ToString()
        {
            return Nev + "\t" + Ár + "\t" + Áfa;
        }

    }
}
