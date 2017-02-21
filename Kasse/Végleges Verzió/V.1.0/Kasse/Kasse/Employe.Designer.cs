namespace Kasse
{
    partial class Employe
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
            this.Alkalmazott_mutato = new System.Windows.Forms.DataGridView();
            this.Employee_regbutton = new System.Windows.Forms.Button();
            this.Employee_updatebutton = new System.Windows.Forms.Button();
            this.Employee_deletebutton = new System.Windows.Forms.Button();
            this.Employee_frissitesbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Alkalmazott_mutato)).BeginInit();
            this.SuspendLayout();
            // 
            // Alkalmazott_mutato
            // 
            this.Alkalmazott_mutato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Alkalmazott_mutato.Location = new System.Drawing.Point(12, 23);
            this.Alkalmazott_mutato.Name = "Alkalmazott_mutato";
            this.Alkalmazott_mutato.Size = new System.Drawing.Size(535, 253);
            this.Alkalmazott_mutato.TabIndex = 0;
            // 
            // Employee_regbutton
            // 
            this.Employee_regbutton.Location = new System.Drawing.Point(553, 23);
            this.Employee_regbutton.Name = "Employee_regbutton";
            this.Employee_regbutton.Size = new System.Drawing.Size(75, 23);
            this.Employee_regbutton.TabIndex = 1;
            this.Employee_regbutton.Text = "Regisztráció";
            this.Employee_regbutton.UseVisualStyleBackColor = true;
            this.Employee_regbutton.Click += new System.EventHandler(this.Employee_regbutton_Click);
            // 
            // Employee_updatebutton
            // 
            this.Employee_updatebutton.Location = new System.Drawing.Point(553, 52);
            this.Employee_updatebutton.Name = "Employee_updatebutton";
            this.Employee_updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Employee_updatebutton.TabIndex = 2;
            this.Employee_updatebutton.Text = "Módosítás";
            this.Employee_updatebutton.UseVisualStyleBackColor = true;
            this.Employee_updatebutton.Click += new System.EventHandler(this.Employee_updatebutton_Click);
            // 
            // Employee_deletebutton
            // 
            this.Employee_deletebutton.Location = new System.Drawing.Point(553, 81);
            this.Employee_deletebutton.Name = "Employee_deletebutton";
            this.Employee_deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Employee_deletebutton.TabIndex = 3;
            this.Employee_deletebutton.Text = "Törlés";
            this.Employee_deletebutton.UseVisualStyleBackColor = true;
            this.Employee_deletebutton.Click += new System.EventHandler(this.Employee_deletebutton_Click);
            // 
            // Employee_frissitesbutton
            // 
            this.Employee_frissitesbutton.Location = new System.Drawing.Point(553, 142);
            this.Employee_frissitesbutton.Name = "Employee_frissitesbutton";
            this.Employee_frissitesbutton.Size = new System.Drawing.Size(75, 23);
            this.Employee_frissitesbutton.TabIndex = 4;
            this.Employee_frissitesbutton.Text = "Frissítés";
            this.Employee_frissitesbutton.UseVisualStyleBackColor = true;
            this.Employee_frissitesbutton.Click += new System.EventHandler(this.Employee_frissitesbutton_Click);
            // 
            // Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 307);
            this.Controls.Add(this.Employee_frissitesbutton);
            this.Controls.Add(this.Employee_deletebutton);
            this.Controls.Add(this.Employee_updatebutton);
            this.Controls.Add(this.Employee_regbutton);
            this.Controls.Add(this.Alkalmazott_mutato);
            this.Name = "Employe";
            this.Text = "Felhasználó";
            ((System.ComponentModel.ISupportInitialize)(this.Alkalmazott_mutato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Alkalmazott_mutato;
        private System.Windows.Forms.Button Employee_regbutton;
        private System.Windows.Forms.Button Employee_updatebutton;
        private System.Windows.Forms.Button Employee_deletebutton;
        private System.Windows.Forms.Button Employee_frissitesbutton;
    }
}