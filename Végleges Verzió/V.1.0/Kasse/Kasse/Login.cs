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
    public partial class Login : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        public Login()
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
        //Pénztár
        private void Cash_button_Click(object sender, EventArgs e)
        {
            try
            {
                Cash ch = new Cash();
                ch.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Kassza megjelenítési hiba.");
            }

        }
        //Bejelentkezés
        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int Kódszám = int.Parse(Azonositotext.Text);
                int Jelszó = int.Parse(Passwordtext.Text);
                string Névmegjelenítés = Azonosito_nev.Text;
                string s = alap.Login(Kódszám, Jelszó);
                Azonosito_nev.Text = s;
                if (Azonosito_nev.Text != "Nincs ilyen felhasználó név!")
                {
                    Gombok(Kódszám);
                    //Bejelentkezés gomb elrejtése, ha kész a bejelentkezés
                    Login_Button.Visible = false;
                }
                else
                {
                    Azonositotext.Text = "";
                    Passwordtext.Text = "";
                    Login_Button.Visible = true;
                    alap.Lekapcsolódás();
                }
                Logger.Info(string.Format("Azonosító:'{0}',Név:'{1}'",Azonositotext.Text,Azonosito_nev.Text),"Bejelentkezés");
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Bejelentkezési hiba!");
                Logger.Error( "Bejelentkezési hiba!", "Login");
            }

        }
        private void Gombok(int Kódszám)
        {
            try
            {
                string beosztas = alap.Beosztas(Kódszám.ToString());
                switch (beosztas)
                {
                    case "Gazdaságis":
                        Employee_button.Visible = true;
                        Account_button.Visible = false;
                        goto case "Készletes";
                    case "Készletes":
                        Product_button.Visible = true;
                        goto case "Pénztáros";
                    case "Pénztáros":
                        Cash_button.Visible = true;
                        Logout_button.Visible = true;
                        break;
                }
                Logger.Info(beosztas,"Munkakör");
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Gombok hiba!");
                Logger.Error("Beosztási hiba","Gombok");
            }

        }
        //Felhasználó betöltése
        private void Employee_button_Click(object sender, EventArgs e)
        {
            try
            {
                Employe Felhasznalo = new Employe();
                Felhasznalo.Show(); //Felhasználó-grafikai felület megejelenítése
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Felhasználó megjelenítési hiba!");
                Logger.Error("Felhasználó megjelenítési hiba!", "Felhasználó betöltés!");
            }

        }
        //Számla betöltése
        private void Account_button_Click(object sender, EventArgs e)
        {
            try
            {
                Account Szamla = new Account();
                Szamla.Show(); //Száma-grafikai felület megejelenítése
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Számla megjelenítési hiba!");
                Logger.Error("Számla megjelenítési hiba!", "Számla megjelenési hiba");
            }

        }
        //Cikk kezelő betöltése
        private void Product_button_Click(object sender, EventArgs e)
        {
            try
            {
                Product Cikk_kezelo = new Product();
                Cikk_kezelo.Show(); //Cikk kezelő-grafikai felület megejelenítése
            }
            catch (Exception)
            {

                MessageBox.Show("HIBA: Termék megjelenítési hiba!");
                Logger.Error("Termék megjelenítési hiba!", "Termék betöltés");
            }

        }
        //Kijelentkezés
        private void Logout_button_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {

                MessageBox.Show("HIBA: Kijelentkezési hiba!");
                Logger.Error("Kijelentkezési hiba!", "Kijelentkezés");
            }

        }
        //Kilépés
        private void Kilépés_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Kilépési hiba!");
                Logger.Error("Kilépési hiba!", "Kilépés");
            }

        }
    }
}
