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
    public partial class UnosPredmetaFrm : UserControl
    {
        UnosPredmetaKontroler kontroler = new UnosPredmetaKontroler();
        public UnosPredmetaFrm()
        {
            InitializeComponent();
        }

        private void UnosPredmetaFrm_Load(object sender, EventArgs e)
        {
            cbKlijent.DataSource = Komunikacija.Instance.PrikaziKlijente();
            cbAdvokati.DataSource = Komunikacija.Instance.PrikaziAdvokate();
            cbVrsta.DataSource = Komunikacija.Instance.PrikaziVrste();
            dgvAdvokati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           
            kontroler.Angazuj(cbAdvokati.SelectedItem);
            dgvAdvokati.DataSource = kontroler.angazovaniAdvokati;
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kontroler.Sacuvaj(cbKlijent.SelectedItem, txtNaziv.Text, dtpDatum.Value, chBArhiviran.Checked , txtOpis.Text, cbFaza.SelectedItem, cbVrsta.SelectedItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
