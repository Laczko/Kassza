namespace Kasse
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Azonositotext = new System.Windows.Forms.TextBox();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.Employee_button = new System.Windows.Forms.Button();
            this.Product_button = new System.Windows.Forms.Button();
            this.Cash_button = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Account_button = new System.Windows.Forms.Button();
            this.Azonosito_nev = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonositó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó:";
            // 
            // Azonositotext
            // 
            this.Azonositotext.Location = new System.Drawing.Point(98, 34);
            this.Azonositotext.Name = "Azonositotext";
            this.Azonositotext.Size = new System.Drawing.Size(100, 20);
            this.Azonositotext.TabIndex = 2;
            // 
            // Passwordtext
            // 
            this.Passwordtext.Location = new System.Drawing.Point(98, 66);
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.PasswordChar = '*';
            this.Passwordtext.Size = new System.Drawing.Size(100, 20);
            this.Passwordtext.TabIndex = 3;
            // 
            // Employee_button
            // 
            this.Employee_button.Location = new System.Drawing.Point(244, 21);
            this.Employee_button.Name = "Employee_button";
            this.Employee_button.Size = new System.Drawing.Size(75, 23);
            this.Employee_button.TabIndex = 4;
            this.Employee_button.Text = "Felhasználó";
            this.Employee_button.UseVisualStyleBackColor = true;
            this.Employee_button.Visible = false;
            this.Employee_button.Click += new System.EventHandler(this.Employee_button_Click);
            // 
            // Product_button
            // 
            this.Product_button.Location = new System.Drawing.Point(244, 79);
            this.Product_button.Name = "Product_button";
            this.Product_button.Size = new System.Drawing.Size(75, 23);
            this.Product_button.TabIndex = 5;
            this.Product_button.Text = "Cikk kezelő";
            this.Product_button.UseVisualStyleBackColor = true;
            this.Product_button.Visible = false;
            this.Product_button.Click += new System.EventHandler(this.Product_button_Click);
            // 
            // Cash_button
            // 
            this.Cash_button.Location = new System.Drawing.Point(244, 108);
            this.Cash_button.Name = "Cash_button";
            this.Cash_button.Size = new System.Drawing.Size(75, 23);
            this.Cash_button.TabIndex = 6;
            this.Cash_button.Text = "Pénztár";
            this.Cash_button.UseVisualStyleBackColor = true;
            this.Cash_button.Visible = false;
            this.Cash_button.Click += new System.EventHandler(this.Cash_button_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.Location = new System.Drawing.Point(98, 144);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(100, 23);
            this.Logout_button.TabIndex = 7;
            this.Logout_button.Text = "Kijelentkezés";
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Visible = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Account_button
            // 
            this.Account_button.Location = new System.Drawing.Point(244, 50);
            this.Account_button.Name = "Account_button";
            this.Account_button.Size = new System.Drawing.Size(75, 23);
            this.Account_button.TabIndex = 8;
            this.Account_button.Text = "Számla";
            this.Account_button.UseVisualStyleBackColor = true;
            this.Account_button.Visible = false;
            this.Account_button.Click += new System.EventHandler(this.Account_button_Click);
            // 
            // Azonosito_nev
            // 
            this.Azonosito_nev.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Azonosito_nev.Location = new System.Drawing.Point(16, 93);
            this.Azonosito_nev.Name = "Azonosito_nev";
            this.Azonosito_nev.Size = new System.Drawing.Size(222, 23);
            this.Azonosito_nev.TabIndex = 9;
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(98, 115);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(100, 23);
            this.Login_Button.TabIndex = 10;
            this.Login_Button.Text = "Bejelentkezés";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 179);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Azonosito_nev);
            this.Controls.Add(this.Account_button);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.Cash_button);
            this.Controls.Add(this.Product_button);
            this.Controls.Add(this.Employee_button);
            this.Controls.Add(this.Passwordtext);
            this.Controls.Add(this.Azonositotext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Azonositotext;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.Button Employee_button;
        private System.Windows.Forms.Button Product_button;
        private System.Windows.Forms.Button Cash_button;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Account_button;
        private System.Windows.Forms.Label Azonosito_nev;
        private System.Windows.Forms.Button Login_Button;
    }
}

