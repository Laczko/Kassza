namespace Kasse
{
    partial class Account
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
            this.Szamla_mutato = new System.Windows.Forms.DataGridView();
            this.Account_regbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Szamla_mutato)).BeginInit();
            this.SuspendLayout();
            // 
            // Szamla_mutato
            // 
            this.Szamla_mutato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Szamla_mutato.Location = new System.Drawing.Point(13, 13);
            this.Szamla_mutato.Name = "Szamla_mutato";
            this.Szamla_mutato.Size = new System.Drawing.Size(562, 190);
            this.Szamla_mutato.TabIndex = 0;
            // 
            // Account_regbutton
            // 
            this.Account_regbutton.Location = new System.Drawing.Point(581, 13);
            this.Account_regbutton.Name = "Account_regbutton";
            this.Account_regbutton.Size = new System.Drawing.Size(75, 23);
            this.Account_regbutton.TabIndex = 1;
            this.Account_regbutton.Text = "Regisztráció";
            this.Account_regbutton.UseVisualStyleBackColor = true;
            this.Account_regbutton.Click += new System.EventHandler(this.Account_regbutton_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 249);
            this.Controls.Add(this.Account_regbutton);
            this.Controls.Add(this.Szamla_mutato);
            this.Name = "Account";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.Szamla_mutato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Szamla_mutato;
        private System.Windows.Forms.Button Account_regbutton;
    }
}