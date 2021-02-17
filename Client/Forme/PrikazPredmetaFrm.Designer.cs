namespace Client.Forme
{
    partial class PrikazPredmetaFrm
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
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.chBArhiviran = new System.Windows.Forms.CheckBox();
            this.cbFaza = new System.Windows.Forms.ComboBox();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dgvAdvokati = new System.Windows.Forms.DataGridView();
            this.cbAdvokati = new System.Windows.Forms.ComboBox();
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvokati)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpis.Location = new System.Drawing.Point(308, 158);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(517, 97);
            this.txtOpis.TabIndex = 40;
            this.txtOpis.Text = "";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(847, 479);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 46);
            this.btnSacuvaj.TabIndex = 39;
            this.btnSacuvaj.Text = "Sacuvaj predmet";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(847, 329);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 34);
            this.btnDodaj.TabIndex = 38;
            this.btnDodaj.Text = "Angazuj advokata";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.Location = new System.Drawing.Point(308, 92);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(517, 20);
            this.dtpDatum.TabIndex = 37;
            // 
            // chBArhiviran
            // 
            this.chBArhiviran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBArhiviran.AutoSize = true;
            this.chBArhiviran.Location = new System.Drawing.Point(308, 126);
            this.chBArhiviran.Name = "chBArhiviran";
            this.chBArhiviran.Size = new System.Drawing.Size(15, 14);
            this.chBArhiviran.TabIndex = 36;
            this.chBArhiviran.UseVisualStyleBackColor = true;
            // 
            // cbFaza
            // 
            this.cbFaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaza.FormattingEnabled = true;
            this.cbFaza.Items.AddRange(new object[] {
            "Prvostepeni postupak",
            "Drugostepeni postupak"});
            this.cbFaza.Location = new System.Drawing.Point(308, 270);
            this.cbFaza.Name = "cbFaza";
            this.cbFaza.Size = new System.Drawing.Size(517, 21);
            this.cbFaza.TabIndex = 35;
            // 
            // cbVrsta
            // 
            this.cbVrsta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Location = new System.Drawing.Point(308, 301);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(517, 21);
            this.cbVrsta.TabIndex = 34;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(308, 62);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(517, 20);
            this.txtNaziv.TabIndex = 33;
            // 
            // dgvAdvokati
            // 
            this.dgvAdvokati.AllowUserToAddRows = false;
            this.dgvAdvokati.AllowUserToDeleteRows = false;
            this.dgvAdvokati.AllowUserToOrderColumns = true;
            this.dgvAdvokati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAdvokati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvokati.Location = new System.Drawing.Point(308, 375);
            this.dgvAdvokati.Name = "dgvAdvokati";
            this.dgvAdvokati.Size = new System.Drawing.Size(517, 150);
            this.dgvAdvokati.TabIndex = 32;
            // 
            // cbAdvokati
            // 
            this.cbAdvokati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAdvokati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdvokati.FormattingEnabled = true;
            this.cbAdvokati.Location = new System.Drawing.Point(308, 329);
            this.cbAdvokati.Name = "cbAdvokati";
            this.cbAdvokati.Size = new System.Drawing.Size(517, 21);
            this.cbAdvokati.TabIndex = 31;
            // 
            // cbKlijent
            // 
            this.cbKlijent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKlijent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKlijent.Enabled = false;
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(308, 28);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(517, 21);
            this.cbKlijent.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Angazovani advokati";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Advokati";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vrsta postupka";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Faza";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Opis";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Arhiviran";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Datum otvaranja predmeta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Naziv predmeta";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Klijent";
            // 
            // PrikazPredmetaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 552);
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
            this.Name = "PrikazPredmetaFrm";
            this.Text = "PrikazPredmetaFrm";
            this.Load += new System.EventHandler(this.PrikazPredmetaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvokati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.CheckBox chBArhiviran;
        private System.Windows.Forms.ComboBox cbFaza;
        private System.Windows.Forms.ComboBox cbVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DataGridView dgvAdvokati;
        private System.Windows.Forms.ComboBox cbAdvokati;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}