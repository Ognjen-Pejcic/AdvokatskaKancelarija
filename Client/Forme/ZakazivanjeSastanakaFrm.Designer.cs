
namespace Client.Forme
{
    partial class ZakazivanjeSastanakaFrm
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgvSastanci = new System.Windows.Forms.DataGridView();
            this.cbAdvokat = new System.Windows.Forms.ComboBox();
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(428, 156);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(171, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj sastanak";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(428, 385);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(171, 23);
            this.btnSacuvaj.TabIndex = 1;
            this.btnSacuvaj.Text = "Sacuvaj sastanke";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dgvSastanci
            // 
            this.dgvSastanci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSastanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastanci.Location = new System.Drawing.Point(93, 195);
            this.dgvSastanci.Name = "dgvSastanci";
            this.dgvSastanci.Size = new System.Drawing.Size(506, 166);
            this.dgvSastanci.TabIndex = 2;
            // 
            // cbAdvokat
            // 
            this.cbAdvokat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAdvokat.FormattingEnabled = true;
            this.cbAdvokat.Location = new System.Drawing.Point(265, 32);
            this.cbAdvokat.Name = "cbAdvokat";
            this.cbAdvokat.Size = new System.Drawing.Size(334, 21);
            this.cbAdvokat.TabIndex = 3;
            // 
            // cbKlijent
            // 
            this.cbKlijent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(265, 71);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(334, 21);
            this.cbKlijent.TabIndex = 4;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.Location = new System.Drawing.Point(265, 110);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(334, 20);
            this.dtpDatum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Advokat";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Klijent";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum i vreme sastanka";
            // 
            // ZakazivanjeSastanakaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbKlijent);
            this.Controls.Add(this.cbAdvokat);
            this.Controls.Add(this.dgvSastanci);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnDodaj);
            this.Name = "ZakazivanjeSastanakaFrm";
            this.Text = "Zakazivanje sastanaka";
            this.Load += new System.EventHandler(this.btnDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgvSastanci;
        private System.Windows.Forms.ComboBox cbAdvokat;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}