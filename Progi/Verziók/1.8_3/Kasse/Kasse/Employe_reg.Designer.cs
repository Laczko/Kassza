namespace Kasse
{
    partial class Employe_reg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kodszam_emp_reg = new System.Windows.Forms.Label();
            this.Nev_Employee_Reg = new System.Windows.Forms.Label();
            this.Password_reg = new System.Windows.Forms.Label();
            this.Beosztas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Kodszam_emp_reg
            // 
            this.Kodszam_emp_reg.AutoSize = true;
            this.Kodszam_emp_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kodszam_emp_reg.Location = new System.Drawing.Point(30, 31);
            this.Kodszam_emp_reg.Name = "Kodszam_emp_reg";
            this.Kodszam_emp_reg.Size = new System.Drawing.Size(61, 13);
            this.Kodszam_emp_reg.TabIndex = 0;
            this.Kodszam_emp_reg.Text = "Kódszám:";
            // 
            // Nev_Employee_Reg
            // 
            this.Nev_Employee_Reg.AutoSize = true;
            this.Nev_Employee_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nev_Employee_Reg.Location = new System.Drawing.Point(30, 58);
            this.Nev_Employee_Reg.Name = "Nev_Employee_Reg";
            this.Nev_Employee_Reg.Size = new System.Drawing.Size(34, 13);
            this.Nev_Employee_Reg.TabIndex = 1;
            this.Nev_Employee_Reg.Text = "Név:";
            // 
            // Password_reg
            // 
            this.Password_reg.AutoSize = true;
            this.Password_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password_reg.Location = new System.Drawing.Point(30, 85);
            this.Password_reg.Name = "Password_reg";
            this.Password_reg.Size = new System.Drawing.Size(46, 13);
            this.Password_reg.TabIndex = 2;
            this.Password_reg.Text = "Jelszó:";
            // 
            // Beosztas
            // 
            this.Beosztas.AutoSize = true;
            this.Beosztas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Beosztas.Location = new System.Drawing.Point(30, 112);
            this.Beosztas.Name = "Beosztas";
            this.Beosztas.Size = new System.Drawing.Size(62, 13);
            this.Beosztas.TabIndex = 3;
            this.Beosztas.Text = "Beosztás:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // Employe_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 226);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Beosztas);
            this.Controls.Add(this.Password_reg);
            this.Controls.Add(this.Nev_Employee_Reg);
            this.Controls.Add(this.Kodszam_emp_reg);
            this.Name = "Employe_reg";
            this.Text = "Employe_reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kodszam_emp_reg;
        private System.Windows.Forms.Label Nev_Employee_Reg;
        private System.Windows.Forms.Label Password_reg;
        private System.Windows.Forms.Label Beosztas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}