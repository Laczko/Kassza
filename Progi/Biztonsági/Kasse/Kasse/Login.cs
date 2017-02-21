using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Kasse
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=Dances-PC\SQLExpress;Initial Catalog=Kasse;Integrated Security=True");
            conn.Open();
        }
        private DataSet ds = new DataSet();
        private SqlConnection conn = new SqlConnection(@"Data Source=Dances-PC\SQLExpress;Initial Catalog=Kasse;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {
        }

        //Pénztár  betöltése
        private void Cash_button_Click(object sender, EventArgs e)
        {
            Cash Penztar = new Cash();
            Penztar.Show(); //Pénztár-grafikai felület megejelenítése

            /*OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dances\Documents\Kasse.accdb");
            con.Open();
            MessageBox.Show("Kapcsolódás!");*/
            //Cash ch = new Cash();
            //ch.Show();
            SqlConnection conn = new SqlConnection(@"Data Source=Dances-PC\SQLExpress;Initial Catalog=Kasse;Integrated Security=True");
            conn.Open();//Kapcsolódás a szerverhez
            DataSet ds = new DataSet();//Összes tábla megjelenítése
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
                SqlDataAdapter da = new SqlDataAdapter("Select Nev from Login where Azonosito=" + Azonositotext.Text, conn);
                da.Fill(ds, "Login");
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
            }*/
        }

        //Bejelentkezés
        private void Login_Button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter db = new SqlDataAdapter("Select Azonosito, Jelszo from Login where Azonosito =" + Azonositotext.Text + " and Jelszo =" + Passwordtext.Text + " ", conn);
            db.Fill(ds, "Login");
            DataColumn Azonosito = new DataColumn("Azonosito");
            //ds.Tables["Login"].Rows[0]["Azonosito"];
            //SqlDataAdapter dc = new SqlDataAdapter("Select Nev from Login where Azonosito=" + Azonositotext.Text, conn);
                //dc.Fill(ds, "Login");
                //Azonosito_nev.Text = ((string)ds.Tables[0].Rows[0]["Nev"]);
                
                Employee_button.Visible = true;
                Account_button.Visible = true;
                Product_button.Visible = true;
                Cash_button.Visible = true;
            
         
                SqlDataAdapter da = new SqlDataAdapter("Select Nev from Login where Azonosito=" + Azonositotext.Text, conn);
                da.Fill(ds, "Login");
                Azonosito_nev.Text = ((string)ds.Tables[0].Rows[0]["Nev"]);
                Cash ch = new Cash();
                ch.Show();
            
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

        }


    }
}
