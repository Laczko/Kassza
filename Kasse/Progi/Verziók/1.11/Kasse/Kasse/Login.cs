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
            Azonosito_nev.Text = s;



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
            Logout_button.Visible = false;

            Azonositotext.Clear();
            Passwordtext.Clear();
            Azonosito_nev.Text = "";
        }

        private void Kilépés_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
