namespace Kasse
{
    partial class Product
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
            this.Termek_mutato = new System.Windows.Forms.DataGridView();
            this.Termek_regbutton = new System.Windows.Forms.Button();
            this.Termek_deletebutton = new System.Windows.Forms.Button();
            this.Termek_updatebutton = new System.Windows.Forms.Button();
            this.Termek_frissitesbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Termek_mutato)).BeginInit();
            this.SuspendLayout();
            // 
            // Termek_mutato
            // 
            this.Termek_mutato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Termek_mutato.Location = new System.Drawing.Point(13, 13);
            this.Termek_mutato.Name = "Termek_mutato";
            this.Termek_mutato.Size = new System.Drawing.Size(517, 205);
            this.Termek_mutato.TabIndex = 0;
            // 
            // Termek_regbutton
            // 
            this.Termek_regbutton.Location = new System.Drawing.Point(536, 13);
            this.Termek_regbutton.Name = "Termek_regbutton";
            this.Termek_regbutton.Size = new System.Drawing.Size(75, 23);
            this.Termek_regbutton.TabIndex = 1;
            this.Termek_regbutton.Text = "Regisztráció";
            this.Termek_regbutton.UseVisualStyleBackColor = true;
            this.Termek_regbutton.Click += new System.EventHandler(this.Termek_regbutton_Click);
            // 
            // Termek_deletebutton
            // 
            this.Termek_deletebutton.Location = new System.Drawing.Point(536, 71);
            this.Termek_deletebutton.Name = "Termek_deletebutton";
            this.Termek_deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Termek_deletebutton.TabIndex = 5;
            this.Termek_deletebutton.Text = "Törlés";
            this.Termek_deletebutton.UseVisualStyleBackColor = true;
            this.Termek_deletebutton.Click += new System.EventHandler(this.Termek_deletebutton_Click);
            // 
            // Termek_updatebutton
            // 
            this.Termek_updatebutton.Location = new System.Drawing.Point(536, 42);
            this.Termek_updatebutton.Name = "Termek_updatebutton";
            this.Termek_updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Termek_updatebutton.TabIndex = 4;
            this.Termek_updatebutton.Text = "Módosítás";
            this.Termek_updatebutton.UseVisualStyleBackColor = true;
            this.Termek_updatebutton.Click += new System.EventHandler(this.Termek_updatebutton_Click);
            // 
            // Termek_frissitesbutton
            // 
            this.Termek_frissitesbutton.Location = new System.Drawing.Point(536, 130);
            this.Termek_frissitesbutton.Name = "Termek_frissitesbutton";
            this.Termek_frissitesbutton.Size = new System.Drawing.Size(75, 23);
            this.Termek_frissitesbutton.TabIndex = 6;
            this.Termek_frissitesbutton.Text = "Frissítés";
            this.Termek_frissitesbutton.UseVisualStyleBackColor = true;
            this.Termek_frissitesbutton.Click += new System.EventHandler(this.Termek_frissitesbutton_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 287);
            this.Controls.Add(this.Termek_frissitesbutton);
            this.Controls.Add(this.Termek_deletebutton);
            this.Controls.Add(this.Termek_updatebutton);
            this.Controls.Add(this.Termek_regbutton);
            this.Controls.Add(this.Termek_mutato);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.Termek_mutato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Termek_mutato;
        private System.Windows.Forms.Button Termek_regbutton;
        private System.Windows.Forms.Button Termek_deletebutton;
        private System.Windows.Forms.Button Termek_updatebutton;
        private System.Windows.Forms.Button Termek_frissitesbutton;
    }
}