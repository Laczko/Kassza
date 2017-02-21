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
    public partial class Login : Alap // Öröklődést megnézni!!!
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        //private AdatbázisQleDb odd;
        public Login()
        {
            InitializeComponent();       
        }

       

        //Pénztár
        private void Cash_button_Click(object sender, EventArgs e)
        {
            Cash ch = new Cash();
            ch.Show();
        }
        //Bejelentkezés
        private void Login_Button_Click(object sender, EventArgs e)
        {
            int Kódszám = int.Parse(Azonositotext.Text);
            int Jelszó = int.Parse(Passwordtext.Text);
            string Névmegjelenítés = Azonosito_nev.Text;
            string s= alap.Login(Kódszám, Jelszó);
            Azonosito_nev.Text = s;//Kasse.AdatbázisQleDb.Login returned	"Dances"	string 



            Employee_button.Visible = true;
            Account_button.Visible = true;
            Product_button.Visible = true;
            Cash_button.Visible = true;
            Logout_button.Visible = true;

            //Bejelentkezés gomb elrejtése, ha kész a bejelentkezés
            Login_Button.Visible = false;
        }
        //Felhasználó betöltése
        private void Employee_button_Click(object sender, EventArgs e)
        {
            Employe Felhasznalo = new Employe();
            Felhasznalo.Show(); //Felhasználó-grafikai felület megejelenítése
        }
        //Számla betöltése
        private void Account_button_Click(object sender, EventArgs e)
        {
            Account Szamla = new Account();
            Szamla.Show(); //Száma-grafikai felület megejelenítése
        }
        //Cikk kezelő betöltése
        private void Product_button_Click(object sender, EventArgs e)
        {
            Product Cikk_kezelo = new Product();
            Cikk_kezelo.Show(); //Cikk kezelő-grafikai felület megejelenítése
        }
        //Kijelentkezés
        private void Logout_button_Click(object sender, EventArgs e)
        {
            alap.Lekapcsolódás();

            Login_Button.Visible = true;
            Employee_button.Visible = false;
            Account_button.Visible = false;
            Product_button.Visible = false;
            Cash_button.Visible = false;

            Azonositotext.Clear();
            Passwordtext.Clear();
            Azonosito_nev.Text = "";
        }

        private void Kilépés_button_Click(object sender, EventArgs e)
        {
            this.Close();
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


  
}
