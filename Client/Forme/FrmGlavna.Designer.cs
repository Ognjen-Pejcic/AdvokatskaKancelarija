﻿
namespace Client.Forme
{
    partial class FrmGlavna
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPretragaKlijenta = new System.Windows.Forms.Button();
            this.btnPretragaPredmeta = new System.Windows.Forms.Button();
            this.btnPretragaSastanaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(177, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kreiranje novog klijenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(177, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zakazivanje sastanaka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(177, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kreiranje predmeta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPretragaKlijenta
            // 
            this.btnPretragaKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretragaKlijenta.Location = new System.Drawing.Point(421, 115);
            this.btnPretragaKlijenta.Name = "btnPretragaKlijenta";
            this.btnPretragaKlijenta.Size = new System.Drawing.Size(178, 23);
            this.btnPretragaKlijenta.TabIndex = 3;
            this.btnPretragaKlijenta.Text = "Pretrazi klijente";
            this.btnPretragaKlijenta.UseVisualStyleBackColor = true;
            this.btnPretragaKlijenta.Click += new System.EventHandler(this.btnPretragaKlijenta_Click);
            // 
            // btnPretragaPredmeta
            // 
            this.btnPretragaPredmeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretragaPredmeta.Location = new System.Drawing.Point(421, 223);
            this.btnPretragaPredmeta.Name = "btnPretragaPredmeta";
            this.btnPretragaPredmeta.Size = new System.Drawing.Size(178, 23);
            this.btnPretragaPredmeta.TabIndex = 4;
            this.btnPretragaPredmeta.Text = "Pretrazi predmete";
            this.btnPretragaPredmeta.UseVisualStyleBackColor = true;
            this.btnPretragaPredmeta.Click += new System.EventHandler(this.btnPretragaPredmeta_Click);
            // 
            // btnPretragaSastanaka
            // 
            this.btnPretragaSastanaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretragaSastanaka.Location = new System.Drawing.Point(421, 171);
            this.btnPretragaSastanaka.Name = "btnPretragaSastanaka";
            this.btnPretragaSastanaka.Size = new System.Drawing.Size(178, 23);
            this.btnPretragaSastanaka.TabIndex = 5;
            this.btnPretragaSastanaka.Text = "Pretrazi sastanke";
            this.btnPretragaSastanaka.UseVisualStyleBackColor = true;
            this.btnPretragaSastanaka.Click += new System.EventHandler(this.btnPretragaSastanaka_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPretragaSastanaka);
            this.Controls.Add(this.btnPretragaPredmeta);
            this.Controls.Add(this.btnPretragaKlijenta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmGlavna";
            this.Text = "FrmGlavna";
            this.Load += new System.EventHandler(this.FrmGlavna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPretragaKlijenta;
        private System.Windows.Forms.Button btnPretragaPredmeta;
        private System.Windows.Forms.Button btnPretragaSastanaka;
    }
}