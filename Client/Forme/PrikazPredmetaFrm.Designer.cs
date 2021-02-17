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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.chBArhiviran = new System.Windows.Forms.CheckBox();
            this.cbFaza = new System.Windows.Forms.ComboBox();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(284, 148);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(356, 97);
            this.txtOpis.TabIndex = 40;
            this.txtOpis.Text = "";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(284, 82);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(356, 20);
            this.dtpDatum.TabIndex = 37;
            // 
            // chBArhiviran
            // 
            this.chBArhiviran.AutoSize = true;
            this.chBArhiviran.Enabled = false;
            this.chBArhiviran.Location = new System.Drawing.Point(284, 116);
            this.chBArhiviran.Name = "chBArhiviran";
            this.chBArhiviran.Size = new System.Drawing.Size(15, 14);
            this.chBArhiviran.TabIndex = 36;
            this.chBArhiviran.UseVisualStyleBackColor = true;
            // 
            // cbFaza
            // 
            this.cbFaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaza.FormattingEnabled = true;
            this.cbFaza.Items.AddRange(new object[] {
            "Prvostepeni postupak",
            "Drugostepeni postupak"});
            this.cbFaza.Location = new System.Drawing.Point(284, 260);
            this.cbFaza.Name = "cbFaza";
            this.cbFaza.Size = new System.Drawing.Size(356, 21);
            this.cbFaza.TabIndex = 35;
            // 
            // cbVrsta
            // 
            this.cbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Location = new System.Drawing.Point(284, 291);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(356, 21);
            this.cbVrsta.TabIndex = 34;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(284, 52);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(356, 20);
            this.txtNaziv.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vrsta postupka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Faza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Arhiviran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Datum otvaranja predmeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Naziv predmeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Klijent";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(675, 260);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 52);
            this.btnSacuvaj.TabIndex = 39;
            this.btnSacuvaj.Text = "Sacuvaj predmet";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtKlijent
            // 
            this.txtKlijent.Enabled = false;
            this.txtKlijent.Location = new System.Drawing.Point(284, 18);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(356, 20);
            this.txtKlijent.TabIndex = 41;
            // 
            // PrikazPredmetaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 329);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.chBArhiviran);
            this.Controls.Add(this.cbFaza);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.txtNaziv);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.CheckBox chBArhiviran;
        private System.Windows.Forms.ComboBox cbFaza;
        private System.Windows.Forms.ComboBox cbVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtKlijent;
    }
}