<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kasse
{
    public partial class Employe : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        public Employe()
        {
            InitializeComponent();
            alap.Alkamazottlekérdező(Alkalmazott_mutato);
        }

        private void Employee_regbutton_Click(object sender, EventArgs e)
        {
            Employe_reg Felhasználó_reg = new Employe_reg();
            Felhasználó_reg.Show();
            
            //Alkalmazott_mutato.DataSource = 
            //06-30/368-59-92 Pista száma
     
        }
    }
   
    }

=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kasse
{
    public partial class Employe : Alap
    {
        AdatbázisQleDb alap = new AdatbázisQleDb();
        public Employe()
        {
            InitializeComponent();
            alap.Alkamazottlekérdező();
        }

        private void Employee_regbutton_Click(object sender, EventArgs e)
        {
            Employe_reg Felhasználó_reg = new Employe_reg();
            Felhasználó_reg.Show();
            
            //Alkalmazott_mutato.DataSource = 
            //06-30/368-59-92 Pista száma
     
        }
    }
   
    }

>>>>>>> 95606b58cd537d586ca0e5b953fffb826f6a2914
