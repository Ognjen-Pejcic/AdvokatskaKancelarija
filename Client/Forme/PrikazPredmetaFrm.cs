﻿
using Client.Kontroleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forme
{
    public partial class PrikazPredmetaFrm : Form
    {
        PrikazPredmetaKontroler kontroler = new PrikazPredmetaKontroler();
        int id;
        private string nazivPremdeta;
        private string opisPredmeta;
        private object vrstaPostupka;
        private object Klijent;
        private bool Arhiviran;
        private string faza;
        private DateTime datum;
        private object angazovanja;
        public PrikazPredmetaFrm()
        {

            InitializeComponent();
        }

        public PrikazPredmetaFrm(int predmetID, object klijent, DateTime datumOtvaranja, bool arhiviran, string nazivPremdeta, string opisPredmeta, object vrstaPostupka, string faza, object angazovanja) 
        {
            this.id = predmetID;
            this.datum = datumOtvaranja;
            this.nazivPremdeta = nazivPremdeta;
            this.Klijent = klijent;
            this.Arhiviran = arhiviran;
            this.opisPredmeta = opisPredmeta;
            this.vrstaPostupka = vrstaPostupka;
            this.faza = faza;
            this.angazovanja = angazovanja;
            InitializeComponent();
        }

        private void PrikazPredmetaFrm_Load(object sender, EventArgs e)
        {
            cbVrsta.DataSource = Komunikacija.Instance.PrikaziVrste();
            txtKlijent.Text = Klijent.ToString();
            txtNaziv.Text = nazivPremdeta;
            txtOpis.Text = opisPredmeta;
            chBArhiviran.Checked = Arhiviran;
            cbFaza.Text = faza;
            dtpDatum.Value = datum;
            
            foreach (var x in cbVrsta.Items)
            {
                if (x.ToString() == vrstaPostupka.ToString())
                {
                    cbVrsta.SelectedItem = x;
                }
            }
            dataGridView1.DataSource = angazovanja;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!chBArhiviran.Checked)
                kontroler.Sacuvaj(id, txtNaziv.Text, dtpDatum.Value, txtOpis.Text, cbFaza.Text, cbVrsta.SelectedItem);
            else MessageBox.Show("Sistem ne moze da izmeni predmet");
        }
    }
}
