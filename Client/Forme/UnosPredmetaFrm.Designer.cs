namespace Client.Forme
{
    partial class UnosPredmetaFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.cbAdvokati = new System.Windows.Forms.ComboBox();
            this.dgvAdvokati = new System.Windows.Forms.DataGridView();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.cbFaza = new System.Windows.Forms.ComboBox();
            this.chBArhiviran = new System.Windows.Forms.CheckBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvokati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klijent";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv predmeta";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum otvaranja predmeta";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arhiviran";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opis";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Faza";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vrsta postupka";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Advokati";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Angazovani advokati";
            // 
            // cbKlijent
            // 
            this.cbKlijent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(324, 43);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(400, 21);
            this.cbKlijent.TabIndex = 9;
            // 
            // cbAdvokati
            // 
            this.cbAdvokati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAdvokati.FormattingEnabled = true;
            this.cbAdvokati.Location = new System.Drawing.Point(324, 344);
            this.cbAdvokati.Name = "cbAdvokati";
            this.cbAdvokati.Size = new System.Drawing.Size(400, 21);
            this.cbAdvokati.TabIndex = 10;
            // 
            // dgvAdvokati
            // 
            this.dgvAdvokati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAdvokati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvokati.Location = new System.Drawing.Point(324, 390);
            this.dgvAdvokati.Name = "dgvAdvokati";
            this.dgvAdvokati.Size = new System.Drawing.Size(400, 150);
            this.dgvAdvokati.TabIndex = 11;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(324, 77);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(400, 20);
            this.txtNaziv.TabIndex = 12;
            // 
            // cbVrsta
            // 
            this.cbVrsta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Location = new System.Drawing.Point(324, 316);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(400, 21);
            this.cbVrsta.TabIndex = 14;
            // 
            // cbFaza
            // 
            this.cbFaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFaza.FormattingEnabled = true;
            this.cbFaza.Items.AddRange(new object[] {
            "Prvostepeni postupak",
            "Drugostepeni postupak"});
            this.cbFaza.Location = new System.Drawing.Point(324, 285);
            this.cbFaza.Name = "cbFaza";
            this.cbFaza.Size = new System.Drawing.Size(400, 21);
            this.cbFaza.TabIndex = 15;
            // 
            // chBArhiviran
            // 
            this.chBArhiviran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBArhiviran.AutoSize = true;
            this.chBArhiviran.Location = new System.Drawing.Point(324, 141);
            this.chBArhiviran.Name = "chBArhiviran";
            this.chBArhiviran.Size = new System.Drawing.Size(15, 14);
            this.chBArhiviran.TabIndex = 16;
            this.chBArhiviran.UseVisualStyleBackColor = true;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.Location = new System.Drawing.Point(324, 107);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(400, 20);
            this.dtpDatum.TabIndex = 17;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(756, 344);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 34);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Angazuj advokata";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(756, 494);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 46);
            this.btnSacuvaj.TabIndex = 19;
            this.btnSacuvaj.Text = "Sacuvaj predmet";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpis.Location = new System.Drawing.Point(324, 173);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(400, 97);
            this.txtOpis.TabIndex = 20;
            this.txtOpis.Text = "";
            // 
            // UnosPredmetaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 604);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.chBArhiviran);
            this.Controls.Add(this.cbFaza);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgvAdvokati);
            this.Controls.Add(this.cbAdvokati);
            this.Controls.Add(this.cbKlijent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnosPredmetaFrm";
            this.Text = "UnosPredmetaFrm";
            this.Load += new System.EventHandler(this.UnosPredmetaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvokati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.ComboBox cbAdvokati;
        private System.Windows.Forms.DataGridView dgvAdvokati;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cbVrsta;
        private System.Windows.Forms.ComboBox cbFaza;
        private System.Windows.Forms.CheckBox chBArhiviran;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.RichTextBox txtOpis;
    }
}