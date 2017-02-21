using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace Kasse
{
    class AdatbázisOracle
    {
        protected DataTable dt;
        protected DataSet ds;
        protected OracleDataAdapter orda;
        protected OracleCommand orco;
        OracleConnection conn = new OracleConnection(@"Data Source=XE; User ID=system; Password=26628");
        public AdatbázisOracle()
        {
        }
        public static AdatbázisOracle sajat;
        public static AdatbázisOracle PeldanySzerez()
        {
            if (sajat == null) sajat = new AdatbázisOracle();
            return sajat;
        }
        public bool Kapcsolódás()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (OracleException ode)
            {

                //MessageBox.Show(ode.Message);
                Logger.Error(ode.Message, "Kapcsolódási hiba");
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
                conn.Dispose();
            }
        }
        public bool CreateTable()
        {
            string lekérdezés = String.Format("Select * from Alkalmazott_reg");
            orco = new OracleCommand(lekérdezés, conn);
            OracleDataReader odr;
            odr = orco.ExecuteReader();//Adatkeresés
            int count = 0;
            while (odr.Read())
            {
                count += 1;
            }
            if (count == 0)
            {
                odr.Close();
                orco = new OracleCommand(String.Format("Create table Alkalmazott_reg(Id varchar2(12) primary key,Azonosito number,Nev varchar2(12),Jelszo number(4),Beosztas varchar2(12)"), conn);
                return true;
            }
            return false;
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
                orco = new OracleCommand(lekérdezés, conn);
                OracleDataReader odr;
                odr = orco.ExecuteReader();//Adatkeresés
                int count = 0;
                while (odr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    odr.Close();
                    orda = new OracleDataAdapter(névmegjelenítés, conn);
                    orda.Fill(ds, "Alkalmazott_reg");
                    Azonosito_nev = ((string)ds.Tables[0].Rows[0]["Nev"]);
                    Logger.Info(Azonosito_nev, "Login");
                    return Azonosito_nev;
                }
                else if (count > 0)
                {
                    MessageBox.Show("Dupla jelszó vagy felhasználónév");
                    Logger.Error("Dupla jelszó vagy felhasználónév", "Login");
                }
                else
                {
                    MessageBox.Show("Felhasználó név vagy jelszó rossz");
                    Logger.Error("Felhasználó név vagy jelszó rossz", "Login");
                }

            }
            catch (OleDbException ode)
            {
                MessageBox.Show(ode.Message);
                Logger.Error(ode.Message, "Login");
            }
            Logger.Error("Nincs ilyen felhasználó név!", "Login");
            return "Nincs ilyen felhasználó név!";

        }
        public string Beosztas(string Kódszám)
        {
            string beosztas;
            try
            {
                string munkakor = String.Format("Select Beosztas from Alkalmazott_reg where Azonosito = {0}", Kódszám);
                orda = new OracleDataAdapter(munkakor, conn);
                ds = new DataSet();
                orda.Fill(ds, "Alkalmazott_reg");
                beosztas = ((string)ds.Tables[0].Rows[0]["Beosztas"]);
                return beosztas;
            }
            catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Beosztasi hiba"); }
            return "";
        }
        public void Alkamazottlekérdező(DataGridView Megjelenito)
        {
            try
            {
                conn.Open();
                string query = String.Format("Select * from Alkalmazott_reg");
                orda = new OracleDataAdapter(query, conn);
                dt = new DataTable();
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                orda.Fill(dt);
                Megjelenito.DataSource = dt;
                orda.Update(dt);
            }
            catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Alkalmazott megjelenítő hiba"); }
            finally { Lekapcsolódás(); }
        }
        /*
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
            catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Számla Megjelenítő hiba"); }
            finally { Lekapcsolódás(); }
        }
        */
        //Számla Megtekintő
        public void Termékmegtekintő(DataGridView Megjelenito)
        {
            try
            {
                conn.Open();
                string query = String.Format("Select * from Termek_reg");
                orda = new OracleDataAdapter(query, conn);
                dt = new DataTable();
                orda.Fill(dt);
                Megjelenito.DataSource = dt;
            }
            catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Termék megjelenítő hiba"); }
            finally { Lekapcsolódás(); }
        }
        public void Tagfelvétel(string kódszám, string Név, string jelszo, string Beosztas)
        {
            try
            {
                conn.Open();
                string query = String.Format("INSERT INTO Alkalmazott_reg (Azonosito,Nev,Jelszo,Beosztas) VALUES ('{0}', '{1}', '{2}', '{3}')", kódszám, Név, jelszo, Beosztas);
                orda = new OracleDataAdapter(query, conn);
                ds = new DataSet();
                orda.Fill(ds);
                Logger.Info(query, "Tagfelvételi adatok");
            }
            catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Tagfelvételi hiba"); }
            finally { Lekapcsolódás(); }
        }
        public void Termékfelvitel(string Vonalkod, string Gyorskód, string Név, string Szállító, string Szállítóikód, string Kategória, int Menny_érték, string Menny_egység, string Kiszerelés, int Eladási_ár, double Nettó, double Akció, DateTime datum, bool Tiltott, string Áfa)
        {
            try
            {
                conn.Open();
                if (Gyorskód == "")
                {
                    Gyorskód = "-1";
                }
                string query = String.Format("INSERT INTO Termek_reg (Vonalkod, Gyorskód, Nev, Szallito, Szallitoi_kod, Kategoria, Mennyisegi_ar, Mennyisegi_egyseg, Kiszereles, Eladasi_ar, Netto_ar, Akcios_ar, Datum, Tiltott_lista, Áfa) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}',{9},{10},{11},'{12}','{13}','{14}');", Vonalkod, Gyorskód, Név, Szállító, Szállítóikód, Kategória, Menny_érték, Menny_egység, Kiszerelés, Convert.ToInt32(Eladási_ár), Convert.ToInt32(Nettó), Convert.ToInt32(Akció), Convert.ToString(datum), Convert.ToString(Tiltott), Áfa);
                orda = new OracleDataAdapter(query, conn);
                ds = new DataSet();
                orda.Fill(ds);
                Logger.Info(query, "Termékfelviteli adatok");
            }
            catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Termékfelviteli hiba"); }
            finally { Lekapcsolódás(); }
        }

        public void SqlParancs(string SQLParancs)
        {
            try
            {
                conn.Open();
                orda = new OracleDataAdapter(SQLParancs, conn);
                ds = new DataSet();
                orda.Fill(ds);

            }
            catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "SqlParancs hiba"); }
            finally { Lekapcsolódás(); }
        }
    }
}
