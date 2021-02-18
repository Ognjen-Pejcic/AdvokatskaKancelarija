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
    public partial class PretragaPredmetaFrm : Form
    {
        PretragaPredmetaKontroler kontroler = new PretragaPredmetaKontroler();
        public PretragaPredmetaFrm()
        {
            InitializeComponent();
            dateTimePicker1.Visible = false;
            textBox1.Visible = false;
        }

        bool provera = true;
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (cbKriterijum.SelectedItem == null)
            {
                MessageBox.Show("Prvo odaberite kriterijum za pretragu");
                textBox1.Text = null;
                return;
            }
           
            object o = new object();
            if (cbKriterijum.SelectedItem.ToString()!= "Datumu otvaranja") {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    dgvRezultat.DataSource = null;
                    return;

                }
                o = kontroler.PrikaziPrdemete(cbKriterijum.SelectedItem.ToString(), textBox1.Text, provera);
            }
            else
            {
                o = kontroler.PrikaziPrdemete(cbKriterijum.SelectedItem.ToString(), dateTimePicker1.Value, provera);
            }
            dgvRezultat.DataSource = o;
            if (o != null)
            {

                dgvRezultat.Columns[0].Visible = false;
                dgvRezultat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            provera = true;
        }

        private void cbKriterijum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKriterijum.SelectedItem.ToString() == "Datumu otvaranja")
            {
                dateTimePicker1.Visible = true;
                textBox1.Visible = false;
            }
            else
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = true;
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (dgvRezultat.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvRezultat.SelectedRows[0];
                object o = row.DataBoundItem;
                kontroler.PrikaziPredmet(o);
            }
            else
            {
                MessageBox.Show("Morate odabrati predmet za prikaz");
                return;
            }
            btnPretrazi_Click(sender, e);
        }

        private void btnArhiviraj_Click(object sender, EventArgs e)
        {
            if (dgvRezultat.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgvRezultat.SelectedRows[0];
                object o;
                if ((bool)row.Cells[4].Value == false) { 
                o = row.DataBoundItem;
                kontroler.ArhivirajPredmet(o);
                }
                else
                {
                    MessageBox.Show("Predmet je vec arhiviran");
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati predmet za prikaz");
                return;
            }
            provera = false;
            btnPretrazi_Click(sender, e);
        }

       
    }
    

}
