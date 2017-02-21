using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.IO;

namespace Kasse
{
    public partial class Login : Form
    {
        private AdatbázisQleDb odb;
        public Login()
        {
            InitializeComponent();
            odb = AdatbázisQleDb.PeldanySzerez();
            odb.Kapcsolódás(Environment.CurrentDirectory + @"\Kasse.accdb");
        }

        

        private void Cash_button_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            int Kódszám = int.Parse(Azonositotext.Text);
            int Jelszó = int.Parse(Passwordtext.Text);
            string Névmegjelenítés = Azonosito_nev.Text;
            odb.Login(Kódszám, Jelszó,Névmegjelenítés);
            Azonosito_nev.Text = "Ide kellene a Felhasználó neve";//Kasse.AdatbázisQleDb.Login returned	"Dances"	string 
            Cash ch = new Cash();
            ch.Show();
            

            Employee_button.Visible = true;
            Account_button.Visible = true;
            Product_button.Visible = true;
            Cash_button.Visible = true;
            Logout_button.Visible = true;
        }


    }
    class AdatbaziskezelésSQL
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=Dances-PC\SQLExpress;Initial Catalog=Kasse;Integrated Security=True");
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private SqlDataAdapter sda = new SqlDataAdapter();
        /*public void Login()
        {
            /*OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dances\Documents\Kasse.accdb");
           con.Open();
           MessageBox.Show("Kapcsolódás!");///Ide Csillagot kell rakni.
            //Cash ch = new Cash();
            //ch.Show();
            SqlConnection conn = new SqlConnection(@"Data Source=Dances-PC\SQLExpress;Initial Catalog=Kasse;Integrated Security=True");
            conn.Open();//Kapcsolódás a szerverhez
            ds = new DataSet();//Összes tábla megjelenítése
            SqlCommand sc = new SqlCommand("Select Azonosito, Jelszo from Login where Azonosito =" + Azonositotext.Text + " and Jelszo =" + Passwordtext.Text + " ", conn);
            SqlDataReader dr;
            dr = sc.ExecuteReader();//Adatkeresés
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                dr.Close();
                sda = new SqlDataAdapter("Select Nev from Login where Azonosito=" + Azonositotext.Text, conn);
                sda.Fill(ds, "Login");
                Azonosito_nev.Text = ((string)ds.Tables[0].Rows[0]["Nev"]);
                Cash ch = new Cash();
                ch.Show();
            }
            else if (count > 0)
            {
                MessageBox.Show("Dupla jelszó vagy felhasználónév");
            }
            else
            {
                MessageBox.Show("Felhasználó név vagy jelszó rossz");
            }
            Azonositotext.Clear();
            Passwordtext.Clear();
            Azonosito_nev.Text = "";
            /*Cash ch = new Cash();
            ch.Show();
            SqlConnection conn = new SqlConnection(@"Data Source=Dances-PC\SQLExpress;Initial Catalog=Kasse;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Zoltán\Emachines E528 laptop\Zoltán\Kasse\Kasse\Kasse.mdf;Integrated Security=True;");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Login where Azonosito =" + Azonositotext.Text + " and Jelszo =" + Passwordtext.Text + " ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "8998")
            {
                this.Hide();
                Cash ch1 = new Cash();
                ch1.Show();
            }
            else
            {
                MessageBox.Show("Rossz Jelszó vagy Felhasználó név!");
            }
         }*/
        }

    
    class AdatbázisQleDb
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
        }
        public string Login(int Azonosito, int Jelszo, string Azonosito_nev)
        {
            try
            {
                conn.Open();
                string lekérdezés = String.Format("Select Azonosito, Jelszo from Alkalmazott_reg where Azonosito = {0} and Jelszo = {1} ", Azonosito, Jelszo);
                //oda = new OleDbDataAdapter(lekérdezés, conn);
                string névmegjelenítés = String.Format("Select Nev from Alkalmazott_reg where Azonosito = {0}", Azonosito);
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
                    return Azonosito_nev = ((string)ds.Tables[0].Rows[0]["Nev"]);
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
            //finally { if (conn.State == ConnectionState.Open) conn.Close(); }

            //ds.Tables["Login"].Rows[0]["Azonosito"];
            //SqlDataAdapter dc = new SqlDataAdapter("Select Nev from Login where Azonosito=" + Azonositotext.Text, conn);
            //dc.Fill(ds, "Login");
            //Azonosito_nev.Text = ((string)ds.Tables[0].Rows[0]["Nev"]);

            /*


            sda = new SqlDataAdapter("Select Nev from Login where Azonosito=" + Azonositotext.Text, conn);
            sda.Fill(ds, "Login");
            Azonosito_nev.Text = ((string)ds.Tables[0].Rows[0]["Nev"]);*/

        }
        
    }
}
