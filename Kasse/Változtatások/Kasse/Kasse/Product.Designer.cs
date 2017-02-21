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
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 287);
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
    }
}