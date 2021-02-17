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
    public partial class PrikazKlijentaFRM : Form
    {
        
        PrikazKlijentaKontroler kontroler = new PrikazKlijentaKontroler();

        private int id;
        private string jMBGKlijenta;
        private string imeKlijenta;
        private string prezime;
        private string adresaKlijenta;
        private string telefonKlijenta;

        public PrikazKlijentaFRM()
        {
           
            InitializeComponent();
        }

        public PrikazKlijentaFRM(int id, string jMBGKlijenta, string imeKlijenta, string prezime, string adresaKlijenta, string telefonKlijenta)
        {
            this.id = id;
            this.jMBGKlijenta = jMBGKlijenta;
            this.imeKlijenta = imeKlijenta;
            this.prezime = prezime;
            this.adresaKlijenta = adresaKlijenta;
            this.telefonKlijenta = telefonKlijenta;
            InitializeComponent();
        }

        private void PrikazKlijentaFRM_Load(object sender, EventArgs e)
        {
            txtJMBG.Text = jMBGKlijenta;
            txtIme.Text = imeKlijenta;
            txtPrezime.Text = prezime;
            txtAdresa.Text = adresaKlijenta;
            txtTelefon.Text = telefonKlijenta;
            MessageBox.Show("Sistem je ucitao klijenta");
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            kontroler.Izmeni(id, txtJMBG.Text, txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text);
        }
    }
}
