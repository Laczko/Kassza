namespace Kasse
{
    partial class Cash
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
            this.Fizetendotext = new System.Windows.Forms.TextBox();
            this.Tetelszamlalotext = new System.Windows.Forms.TextBox();
            this.Fizetendo = new System.Windows.Forms.Label();
            this.Tetelszamlalo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tetel_input = new System.Windows.Forms.TextBox();
            this.KP_button = new System.Windows.Forms.Button();
            this.Card_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.Igen_Enter = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.termekek_listBox1 = new System.Windows.Forms.ListBox();
            this.Torles_button10 = new System.Windows.Forms.Button();
            this.fizetett_textBox = new System.Windows.Forms.TextBox();
            this.visszajaro_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uj_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fizetendotext
            // 
            this.Fizetendotext.Location = new System.Drawing.Point(12, 13);
            this.Fizetendotext.Name = "Fizetendotext";
            this.Fizetendotext.ReadOnly = true;
            this.Fizetendotext.Size = new System.Drawing.Size(158, 20);
            this.Fizetendotext.TabIndex = 0;
            // 
            // Tetelszamlalotext
            // 
            this.Tetelszamlalotext.Location = new System.Drawing.Point(309, 13);
            this.Tetelszamlalotext.Name = "Tetelszamlalotext";
            this.Tetelszamlalotext.ReadOnly = true;
            this.Tetelszamlalotext.Size = new System.Drawing.Size(129, 20);
            this.Tetelszamlalotext.TabIndex = 1;
            // 
            // Fizetendo
            // 
            this.Fizetendo.AutoSize = true;
            this.Fizetendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Fizetendo.Location = new System.Drawing.Point(12, 40);
            this.Fizetendo.Name = "Fizetendo";
            this.Fizetendo.Size = new System.Drawing.Size(62, 13);
            this.Fizetendo.TabIndex = 2;
            this.Fizetendo.Text = "Fizetendő";
            // 
            // Tetelszamlalo
            // 
            this.Tetelszamlalo.AutoSize = true;
            this.Tetelszamlalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tetelszamlalo.Location = new System.Drawing.Point(306, 40);
            this.Tetelszamlalo.Name = "Tetelszamlalo";
            this.Tetelszamlalo.Size = new System.Drawing.Size(50, 13);
            this.Tetelszamlalo.TabIndex = 3;
            this.Tetelszamlalo.Text = "Tételek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tétel:";
            // 
            // Tetel_input
            // 
            this.Tetel_input.Location = new System.Drawing.Point(62, 447);
            this.Tetel_input.MaxLength = 20;
            this.Tetel_input.Name = "Tetel_input";
            this.Tetel_input.Size = new System.Drawing.Size(376, 20);
            this.Tetel_input.TabIndex = 6;
            // 
            // KP_button
            // 
            this.KP_button.Location = new System.Drawing.Point(511, 106);
            this.KP_button.Name = "KP_button";
            this.KP_button.Size = new System.Drawing.Size(75, 23);
            this.KP_button.TabIndex = 7;
            this.KP_button.Text = "KP";
            this.KP_button.UseVisualStyleBackColor = true;
            this.KP_button.Click += new System.EventHandler(this.KP_button_Click);
            // 
            // Card_button
            // 
            this.Card_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Card_button.Location = new System.Drawing.Point(593, 105);
            this.Card_button.Name = "Card_button";
            this.Card_button.Size = new System.Drawing.Size(75, 23);
            this.Card_button.TabIndex = 8;
            this.Card_button.Text = "Kártya";
            this.Card_button.UseVisualStyleBackColor = true;
            this.Card_button.Click += new System.EventHandler(this.Card_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(592, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(511, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 35);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(552, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 35);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(592, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 35);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(511, 141);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 35);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(551, 141);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 35);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(592, 141);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 35);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(511, 264);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(34, 35);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // Igen_Enter
            // 
            this.Igen_Enter.Location = new System.Drawing.Point(552, 264);
            this.Igen_Enter.Name = "Igen_Enter";
            this.Igen_Enter.Size = new System.Drawing.Size(74, 35);
            this.Igen_Enter.TabIndex = 19;
            this.Igen_Enter.Text = "Összesen/ Enter";
            this.Igen_Enter.UseVisualStyleBackColor = true;
            this.Igen_Enter.Click += new System.EventHandler(this.Igen_Enter_Click);
            this.Igen_Enter.Enter += new System.EventHandler(this.Igen_Enter_Enter);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(635, 223);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(35, 35);
            this.buttonX.TabIndex = 20;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // termekek_listBox1
            // 
            this.termekek_listBox1.FormattingEnabled = true;
            this.termekek_listBox1.Location = new System.Drawing.Point(15, 56);
            this.termekek_listBox1.Name = "termekek_listBox1";
            this.termekek_listBox1.Size = new System.Drawing.Size(423, 368);
            this.termekek_listBox1.TabIndex = 21;
            // 
            // Torles_button10
            // 
            this.Torles_button10.Location = new System.Drawing.Point(635, 264);
            this.Torles_button10.Name = "Torles_button10";
            this.Torles_button10.Size = new System.Drawing.Size(36, 35);
            this.Torles_button10.TabIndex = 22;
            this.Torles_button10.Text = "Del";
            this.Torles_button10.UseVisualStyleBackColor = true;
            this.Torles_button10.Click += new System.EventHandler(this.Torles_button10_Click);
            // 
            // fizetett_textBox
            // 
            this.fizetett_textBox.Location = new System.Drawing.Point(513, 325);
            this.fizetett_textBox.Name = "fizetett_textBox";
            this.fizetett_textBox.ReadOnly = true;
            this.fizetett_textBox.Size = new System.Drawing.Size(158, 20);
            this.fizetett_textBox.TabIndex = 23;
            // 
            // visszajaro_textBox
            // 
            this.visszajaro_textBox.Location = new System.Drawing.Point(513, 351);
            this.visszajaro_textBox.Name = "visszajaro_textBox";
            this.visszajaro_textBox.ReadOnly = true;
            this.visszajaro_textBox.Size = new System.Drawing.Size(158, 20);
            this.visszajaro_textBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(459, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fizetett:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(444, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Visszajáró:";
            // 
            // uj_button
            // 
            this.uj_button.Location = new System.Drawing.Point(635, 141);
            this.uj_button.Name = "uj_button";
            this.uj_button.Size = new System.Drawing.Size(36, 35);
            this.uj_button.TabIndex = 27;
            this.uj_button.Text = "Új";
            this.uj_button.UseVisualStyleBackColor = true;
            this.uj_button.Click += new System.EventHandler(this.uj_button_Click);
            // 
            // Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 480);
            this.Controls.Add(this.uj_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visszajaro_textBox);
            this.Controls.Add(this.fizetett_textBox);
            this.Controls.Add(this.Torles_button10);
            this.Controls.Add(this.termekek_listBox1);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.Igen_Enter);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Card_button);
            this.Controls.Add(this.KP_button);
            this.Controls.Add(this.Tetel_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tetelszamlalo);
            this.Controls.Add(this.Fizetendo);
            this.Controls.Add(this.Tetelszamlalotext);
            this.Controls.Add(this.Fizetendotext);
            this.Name = "Cash";
            this.Text = "Cash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fizetendotext;
        private System.Windows.Forms.TextBox Tetelszamlalotext;
        private System.Windows.Forms.Label Fizetendo;
        private System.Windows.Forms.Label Tetelszamlalo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tetel_input;
        private System.Windows.Forms.Button KP_button;
        private System.Windows.Forms.Button Card_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button Igen_Enter;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.ListBox termekek_listBox1;
        private System.Windows.Forms.Button Torles_button10;
        private System.Windows.Forms.TextBox fizetett_textBox;
        private System.Windows.Forms.TextBox visszajaro_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uj_button;
    }
}