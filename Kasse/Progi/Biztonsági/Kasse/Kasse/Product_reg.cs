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

namespace Kasse
{
    public partial class Product_reg : Form
    {
        public Product_reg()
        {
            InitializeComponent();
        }

        private void Mentes_Button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Dances-PC\SQLExpress;Initial Catalog=Kasse;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
        }
    }
}
