namespace Credit_card
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardnumber_textbox = new System.Windows.Forms.TextBox();
            this.CardNumber_Label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.validlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Cardtulaj_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Card4N_label = new System.Windows.Forms.Label();
            this.CCV_label = new System.Windows.Forms.Label();
            this.Alairas_label = new System.Windows.Forms.Label();
            this.Amex_radB = new System.Windows.Forms.RadioButton();
            this.Diners_radB = new System.Windows.Forms.RadioButton();
            this.Discover_radB = new System.Windows.Forms.RadioButton();
            this.Enroute_radB = new System.Windows.Forms.RadioButton();
            this.JCB_15_radB = new System.Windows.Forms.RadioButton();
            this.JCB_16_radB = new System.Windows.Forms.RadioButton();
            this.Mastercard_radB = new System.Windows.Forms.RadioButton();
            this.Visa_radB = new System.Windows.Forms.RadioButton();
            this.Voyager_radB = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Hiba = new System.Windows.Forms.ErrorProvider(this.components);
            this.Valódi_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiba)).BeginInit();
            this.SuspendLayout();
            // 
            // cardnumber_textbox
            // 
            this.cardnumber_textbox.Location = new System.Drawing.Point(118, 427);
            this.cardnumber_textbox.MaxLength = 16;
            this.cardnumber_textbox.Name = "cardnumber_textbox";
            this.cardnumber_textbox.Size = new System.Drawing.Size(201, 20);
            this.cardnumber_textbox.TabIndex = 1;
            this.cardnumber_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.cardnumber_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardnumber_textbox_KeyPress);
            // 
            // CardNumber_Label
            // 
            this.CardNumber_Label.BackColor = System.Drawing.SystemColors.Control;
            this.CardNumber_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CardNumber_Label.ForeColor = System.Drawing.Color.White;
            this.CardNumber_Label.Location = new System.Drawing.Point(42, 219);
            this.CardNumber_Label.Name = "CardNumber_Label";
            this.CardNumber_Label.Size = new System.Drawing.Size(529, 58);
            this.CardNumber_Label.TabIndex = 3;
            this.CardNumber_Label.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Credit_card.Properties.Resources.PCC_back;
            this.pictureBox2.Location = new System.Drawing.Point(612, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(583, 351);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // validlabel
            // 
            this.validlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.validlabel.ForeColor = System.Drawing.Color.White;
            this.validlabel.Location = new System.Drawing.Point(258, 268);
            this.validlabel.Name = "validlabel";
            this.validlabel.Size = new System.Drawing.Size(109, 49);
            this.validlabel.TabIndex = 4;
            this.validlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.validlabel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Namelabel
            // 
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Namelabel.ForeColor = System.Drawing.Color.Orange;
            this.Namelabel.Location = new System.Drawing.Point(45, 310);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(413, 38);
            this.Namelabel.TabIndex = 6;
            this.Namelabel.TextChanged += new System.EventHandler(this.Cardtulaj_textBox1_TextChanged);
            // 
            // Cardtulaj_textBox1
            // 
            this.Hiba.SetError(this.Cardtulaj_textBox1, "Testing");
            this.Cardtulaj_textBox1.Location = new System.Drawing.Point(153, 473);
            this.Cardtulaj_textBox1.Name = "Cardtulaj_textBox1";
            this.Cardtulaj_textBox1.Size = new System.Drawing.Size(166, 20);
            this.Cardtulaj_textBox1.TabIndex = 7;
            this.Cardtulaj_textBox1.TextChanged += new System.EventHandler(this.Cardtulaj_textBox1_TextChanged);
            this.Cardtulaj_textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cardtulaj_textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kártya szám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Érvényességi idő:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kártya tulajdonos:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 450);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.Validnumber_textBox_TextChanged);
            // 
            // Card4N_label
            // 
            this.Card4N_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Card4N_label.ForeColor = System.Drawing.Color.White;
            this.Card4N_label.Location = new System.Drawing.Point(52, 281);
            this.Card4N_label.Name = "Card4N_label";
            this.Card4N_label.Size = new System.Drawing.Size(100, 23);
            this.Card4N_label.TabIndex = 12;
            // 
            // CCV_label
            // 
            this.CCV_label.Location = new System.Drawing.Point(1030, 135);
            this.CCV_label.Name = "CCV_label";
            this.CCV_label.Size = new System.Drawing.Size(63, 36);
            this.CCV_label.TabIndex = 13;
            this.CCV_label.Text = "label5";
            // 
            // Alairas_label
            // 
            this.Alairas_label.Font = new System.Drawing.Font("ParkAvenue BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alairas_label.ForeColor = System.Drawing.Color.Black;
            this.Alairas_label.Location = new System.Drawing.Point(638, 145);
            this.Alairas_label.Name = "Alairas_label";
            this.Alairas_label.Size = new System.Drawing.Size(371, 37);
            this.Alairas_label.TabIndex = 14;
            this.Alairas_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Alairas_label.TextChanged += new System.EventHandler(this.Cardtulaj_textBox1_TextChanged);
            // 
            // Amex_radB
            // 
            this.Amex_radB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Amex_radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Amex_radB.Location = new System.Drawing.Point(114, 384);
            this.Amex_radB.Name = "Amex_radB";
            this.Amex_radB.Size = new System.Drawing.Size(104, 37);
            this.Amex_radB.TabIndex = 15;
            this.Amex_radB.Text = "Amex";
            this.Amex_radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Amex_radB.UseVisualStyleBackColor = true;
            this.Amex_radB.CheckedChanged += new System.EventHandler(this.CardTipus);
            // 
            // Diners_radB
            // 
            this.Diners_radB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Diners_radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Diners_radB.Location = new System.Drawing.Point(224, 384);
            this.Diners_radB.Name = "Diners_radB";
            this.Diners_radB.Size = new System.Drawing.Size(85, 37);
            this.Diners_radB.TabIndex = 16;
            this.Diners_radB.Text = "Diners";
            this.Diners_radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Diners_radB.UseVisualStyleBackColor = true;
            this.Diners_radB.CheckedChanged += new System.EventHandler(this.CardTipus);
            // 
            // Discover_radB
            // 
            this.Discover_radB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Discover_radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Discover_radB.Location = new System.Drawing.Point(315, 384);
            this.Discover_radB.Name = "Discover_radB";
            this.Discover_radB.Size = new System.Drawing.Size(85, 37);
            this.Discover_radB.TabIndex = 17;
            this.Discover_radB.Text = "Discover";
            this.Discover_radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Discover_radB.UseVisualStyleBackColor = true;
            this.Discover_radB.CheckedChanged += new System.EventHandler(this.CardTipus);
            // 
            // Enroute_radB
            // 
            this.Enroute_radB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Enroute_radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Enroute_radB.Location = new System.Drawing.Point(406, 384);
            this.Enroute_radB.Name = "Enroute_radB";
            this.Enroute_radB.Size = new System.Drawing.Size(85, 37);
            this.Enroute_radB.TabIndex = 18;
            this.Enroute_radB.Text = "Enroute";
            this.Enroute_radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enroute_radB.UseVisualStyleBackColor = true;
            this.Enroute_radB.CheckedChanged += new System.EventHandler(this.CardTipus);
            // 
            // JCB_15_radB
            // 
            this.JCB_15_radB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.JCB_15_radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JCB_15_radB.Location = new System.Drawing.Point(497, 384);
            this.JCB_15_radB.Name = "JCB_15_radB";
            this.JCB_15_radB.Size = new System.Drawing.Size(85, 37);
            this.JCB_15_radB.TabIndex = 19;
            this.JCB_15_radB.Text = "JCB-15";
            this.JCB_15_radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JCB_15_radB.UseVisualStyleBackColor = true;
            this.JCB_15_radB.CheckedChanged += new System.EventHandler(this.CardTipus);
            // 
            // JCB_16_radB
            // 
            this.JCB_16_radB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.JCB_16_radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JCB_16_radB.Location = new System.Drawing.Point(588, 384);
            this.JCB_16_radB.Name = "JCB_16_radB";
            this.JCB_16_radB.Size = new System.Drawing.Size(85, 37);
            this.JCB_16_radB.TabIndex = 20;
            this.JCB_16_radB.Text = "JCB-16";
            this.JCB_16_radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JCB_16_radB.UseVisualStyleBackColor = true;
            this.JCB_16_radB.CheckedChanged += new System.EventHandler(this.CardTipus);
            // 
            // Mastercard_radB
            // 
            this.Mastercard_radB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Mastercard_radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mastercard_radB.Location = new System.Drawing.Point(679, 384);
            this.Mastercard_radB.Name = "Mastercard_radB";
            this.Mastercard_radB.Size = new System.Drawing.Size(85, 37);
            this.Mastercard_radB.TabIndex = 21;
            this.Mastercard_radB.Text = "Mastercard";
            this.Mastercard_radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mastercard_radB.UseVisualStyleBackColor = true;
            this.Mastercard_radB.CheckedChanged += new System.EventHandler(this.CardTipus);
            // 
            // Visa_radB
            // 
            this.Visa_radB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Visa_radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Visa_radB.Location = new System.Drawing.Point(770, 384);
            this.Visa_radB.Name = "Visa_radB";
            this.Visa_radB.Size = new System.Drawing.Size(85, 37);
            this.Visa_radB.TabIndex = 22;
            this.Visa_radB.Text = "Visa";
            this.Visa_radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Visa_radB.UseVisualStyleBackColor = true;
            this.Visa_radB.CheckedChanged += new System.EventHandler(this.CardTipus);
            // 
            // Voyager_radB
            // 
            this.Voyager_radB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Voyager_radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Voyager_radB.Location = new System.Drawing.Point(861, 384);
            this.Voyager_radB.Name = "Voyager_radB";
            this.Voyager_radB.Size = new System.Drawing.Size(85, 37);
            this.Voyager_radB.TabIndex = 23;
            this.Voyager_radB.Text = "Voyager";
            this.Voyager_radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Voyager_radB.UseVisualStyleBackColor = true;
            this.Voyager_radB.CheckedChanged += new System.EventHandler(this.CardTipus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kártya típus:";
            // 
            // Hiba
            // 
            this.Hiba.ContainerControl = this;
            this.Hiba.RightToLeftChanged += new System.EventHandler(this.Cardtulaj_textBox1_TextChanged);
            // 
            // Valódi_checkbox
            // 
            this.Valódi_checkbox.AutoSize = true;
            this.Valódi_checkbox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Valódi_checkbox.Enabled = false;
            this.Valódi_checkbox.Location = new System.Drawing.Point(326, 428);
            this.Valódi_checkbox.Name = "Valódi_checkbox";
            this.Valódi_checkbox.Size = new System.Drawing.Size(96, 31);
            this.Valódi_checkbox.TabIndex = 25;
            this.Valódi_checkbox.Text = "Valódi kártyaszám";
            this.Valódi_checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Valódi_checkbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 502);
            this.Controls.Add(this.Valódi_checkbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Voyager_radB);
            this.Controls.Add(this.Visa_radB);
            this.Controls.Add(this.Mastercard_radB);
            this.Controls.Add(this.JCB_16_radB);
            this.Controls.Add(this.JCB_15_radB);
            this.Controls.Add(this.Enroute_radB);
            this.Controls.Add(this.Discover_radB);
            this.Controls.Add(this.Diners_radB);
            this.Controls.Add(this.Amex_radB);
            this.Controls.Add(this.Alairas_label);
            this.Controls.Add(this.CCV_label);
            this.Controls.Add(this.Card4N_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cardtulaj_textBox1);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.validlabel);
            this.Controls.Add(this.CardNumber_Label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cardnumber_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AEnces Bank card";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cardnumber_textbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CardNumber_Label;
        private System.Windows.Forms.Label validlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox Cardtulaj_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Card4N_label;
        private System.Windows.Forms.Label CCV_label;
        private System.Windows.Forms.Label Alairas_label;
        private System.Windows.Forms.RadioButton Amex_radB;
        private System.Windows.Forms.RadioButton Diners_radB;
        private System.Windows.Forms.RadioButton Discover_radB;
        private System.Windows.Forms.RadioButton Enroute_radB;
        private System.Windows.Forms.RadioButton JCB_15_radB;
        private System.Windows.Forms.RadioButton JCB_16_radB;
        private System.Windows.Forms.RadioButton Mastercard_radB;
        private System.Windows.Forms.RadioButton Visa_radB;
        private System.Windows.Forms.RadioButton Voyager_radB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider Hiba;
        private System.Windows.Forms.CheckBox Valódi_checkbox;
    }
}

