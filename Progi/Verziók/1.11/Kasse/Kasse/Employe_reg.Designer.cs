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
            this.Kodszam_text = new System.Windows.Forms.TextBox();
            this.Tag_Nev_text = new System.Windows.Forms.TextBox();
            this.Tag_jelszo_text = new System.Windows.Forms.TextBox();
            this.Employe_mentesbutton = new System.Windows.Forms.Button();
            this.Cash_radbutton = new System.Windows.Forms.RadioButton();
            this.Product_radbutton = new System.Windows.Forms.RadioButton();
            this.Gazd_radbutton = new System.Windows.Forms.RadioButton();
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
            this.Beosztas.Size = new System.Drawing.Size(67, 13);
            this.Beosztas.TabIndex = 3;
            this.Beosztas.Text = "Munkakör:";
            // 
            // Kodszam_text
            // 
            this.Kodszam_text.Location = new System.Drawing.Point(114, 24);
            this.Kodszam_text.Name = "Kodszam_text";
            this.Kodszam_text.Size = new System.Drawing.Size(100, 20);
            this.Kodszam_text.TabIndex = 4;
            // 
            // Tag_Nev_text
            // 
            this.Tag_Nev_text.Location = new System.Drawing.Point(114, 51);
            this.Tag_Nev_text.Name = "Tag_Nev_text";
            this.Tag_Nev_text.Size = new System.Drawing.Size(100, 20);
            this.Tag_Nev_text.TabIndex = 5;
            // 
            // Tag_jelszo_text
            // 
            this.Tag_jelszo_text.Location = new System.Drawing.Point(114, 78);
            this.Tag_jelszo_text.Name = "Tag_jelszo_text";
            this.Tag_jelszo_text.Size = new System.Drawing.Size(100, 20);
            this.Tag_jelszo_text.TabIndex = 6;
            // 
            // Employe_mentesbutton
            // 
            this.Employe_mentesbutton.Location = new System.Drawing.Point(290, 24);
            this.Employe_mentesbutton.Name = "Employe_mentesbutton";
            this.Employe_mentesbutton.Size = new System.Drawing.Size(75, 23);
            this.Employe_mentesbutton.TabIndex = 8;
            this.Employe_mentesbutton.Text = "Mentés";
            this.Employe_mentesbutton.UseVisualStyleBackColor = true;
            this.Employe_mentesbutton.Click += new System.EventHandler(this.Employe_mentesbutton_Click);
            // 
            // Cash_radbutton
            // 
            this.Cash_radbutton.AutoSize = true;
            this.Cash_radbutton.Location = new System.Drawing.Point(114, 107);
            this.Cash_radbutton.Name = "Cash_radbutton";
            this.Cash_radbutton.Size = new System.Drawing.Size(72, 17);
            this.Cash_radbutton.TabIndex = 9;
            this.Cash_radbutton.Text = "Pénztáros";
            this.Cash_radbutton.UseVisualStyleBackColor = true;
            this.Cash_radbutton.CheckedChanged += new System.EventHandler(this.Radbutton_CheckedChanged);
            // 
            // Product_radbutton
            // 
            this.Product_radbutton.AutoSize = true;
            this.Product_radbutton.Location = new System.Drawing.Point(114, 130);
            this.Product_radbutton.Name = "Product_radbutton";
            this.Product_radbutton.Size = new System.Drawing.Size(70, 17);
            this.Product_radbutton.TabIndex = 10;
            this.Product_radbutton.Text = "Készletes";
            this.Product_radbutton.UseVisualStyleBackColor = true;
            this.Product_radbutton.CheckedChanged += new System.EventHandler(this.Radbutton_CheckedChanged);
            // 
            // Gazd_radbutton
            // 
            this.Gazd_radbutton.AutoSize = true;
            this.Gazd_radbutton.Location = new System.Drawing.Point(114, 153);
            this.Gazd_radbutton.Name = "Gazd_radbutton";
            this.Gazd_radbutton.Size = new System.Drawing.Size(80, 17);
            this.Gazd_radbutton.TabIndex = 11;
            this.Gazd_radbutton.Text = "Gazdaságis";
            this.Gazd_radbutton.UseVisualStyleBackColor = true;
            this.Gazd_radbutton.CheckedChanged += new System.EventHandler(this.Radbutton_CheckedChanged);
            // 
            // Employe_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 226);
            this.Controls.Add(this.Gazd_radbutton);
            this.Controls.Add(this.Product_radbutton);
            this.Controls.Add(this.Cash_radbutton);
            this.Controls.Add(this.Employe_mentesbutton);
            this.Controls.Add(this.Tag_jelszo_text);
            this.Controls.Add(this.Tag_Nev_text);
            this.Controls.Add(this.Kodszam_text);
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
        private System.Windows.Forms.TextBox Kodszam_text;
        private System.Windows.Forms.TextBox Tag_Nev_text;
        private System.Windows.Forms.TextBox Tag_jelszo_text;
        private System.Windows.Forms.Button Employe_mentesbutton;
        private System.Windows.Forms.RadioButton Cash_radbutton;
        private System.Windows.Forms.RadioButton Product_radbutton;
        private System.Windows.Forms.RadioButton Gazd_radbutton;
    }
}