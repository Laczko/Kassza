using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Windows.Forms;
namespace Kasse
{
    class Termekek
    {
        protected OracleCommand oc;
        OracleConnection conn = new OracleConnection(@"Data Source=XE;Persist Security Info=True;User ID=system;Password=26628");


        protected string nev;
        protected string ár;
        protected string áfa;

        public string Nev
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

        public string Ár
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

        public string Áfa
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
            Alap.AdatbázisOracle AB = new Alap.AdatbázisOracle();
            List<Termekek> LISTA = new List<Termekek>();
            try
            {

                conn.Open();
                string query = String.Format("Select Nev,Eladasi_ar,Áfa from Termek_reg where Vonalkod ='{0}'or Gyorskód = '{0}'", Termékkód);
                oc = new OracleCommand(query, conn);
                OracleDataReader odr;
                odr = oc.ExecuteReader();//Adatkeresés
                while (odr.Read())
                {
                    Termekek T = new Termekek();
                    T.Nev = odr[0].ToString();
                    T.Ár = odr[1].ToString();
                    T.Áfa = odr[2].ToString();
                    odr.Close();
                    LISTA.Add(T);
                    Logger.Info(Termékkód, "Termék");
                    return LISTA;
                }
            }
            catch (OracleException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Termék keresési hiba!"); }
            finally { conn.Close(); }
            return LISTA;
        }

        public double Osszead(List<Termekek> árak)
        {
            try
            {
                double osszeg = 0;
                for (int i = 0; i < árak.Count; i++)
                {
                    osszeg = osszeg + Convert.ToDouble(árak[i].ár);
                }
                return osszeg;
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Összeadási hiba");
                Logger.Error("Összeadási hiba!", "Osszead");
                return -1;
            }

        }

        /// <summary>
        /// Kerekítés szabályainak megfelelően kerekíti a bemeneti összeget
        /// </summary>
        /// <param name="bemenet">Bemeneti összeg</param>
        /// <returns>Kerekített kimenet</returns>
        public double kerekit(int bemenet)
        {
            try
            {
                double kimenet = bemenet;
                double maradek = bemenet % 10;
                if (maradek >= 8) kimenet += (10 - maradek);
                else if (maradek >= 6 && maradek <= 7) kimenet -= (maradek - 5);
                else if (maradek >= 3 && maradek <= 4) kimenet += (5 - maradek);
                else if (maradek >= 1 && maradek <= 2) kimenet -= maradek;
                return kimenet;
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Kerekítési hiba!");
                Logger.Error("Kerekítési hiba", "Kerekit függvény");
                return -1;
            }

        }

        public override string ToString()
        {
            return Nev + "\t" + Ár + "\t" + Áfa;
        }
    }
}
