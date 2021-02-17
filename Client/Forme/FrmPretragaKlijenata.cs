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
    public partial class FrmPretragaKlijenata : Form
    {
        PretragaKlijenataKontroler kontroler = new PretragaKlijenataKontroler();
        bool provera;
        public FrmPretragaKlijenata()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (dgvRezultat.SelectedRows.Count > 0) { 
            DataGridViewRow row = dgvRezultat.SelectedRows[0];
            object o = row.DataBoundItem;
            kontroler.PrikaziKlijenta(o);
            }
            else
            {
                MessageBox.Show("Morate odabrati klijenta za prikaz");
                return;
            }
            provera = false;
            btnPretrazi_Click(sender,e);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (cbKriterijum.SelectedItem == null)
            {
                MessageBox.Show("Prvo odaberite kriterijum za pretragu");
                textBox1.Text = null;
                return;
            }
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                dgvRezultat.DataSource = null;
                return;
            }
            object o = kontroler.PrikaziKlijente(cbKriterijum.SelectedItem.ToString(), textBox1.Text, provera);
            dgvRezultat.DataSource = o;
            if (o != null)
            { 
              
                dgvRezultat.Columns[0].Visible = false;
                dgvRezultat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            provera = true;
        }
    }
}
