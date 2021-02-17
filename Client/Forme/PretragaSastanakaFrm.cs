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
    public partial class PretragaSastanakaFrm : Form
    {
        PretragaSastanakaKontroler kontroler = new PretragaSastanakaKontroler();
        public PretragaSastanakaFrm()
        {
            InitializeComponent();
            dateTimePicker1.Visible = false;
            textBox1.Visible = false;
        }

    
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (cbKriterijum.SelectedItem == null)
            {
                MessageBox.Show("Prvo odaberite kriterijum za pretragu");
                textBox1.Text = null;
                return;
            }

            object o = new object();
            if (cbKriterijum.SelectedItem.ToString() != "Datumu")
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    dgvRezultat.DataSource = null;
                    return;

                }
                o = kontroler.PrikaziSastanke(cbKriterijum.SelectedItem.ToString(), textBox1.Text);
            }
            else
            {
                o = kontroler.PrikaziSastanke(cbKriterijum.SelectedItem.ToString(), dateTimePicker1.Value);
            }
            dgvRezultat.DataSource = o;
            if (o != null)
            {

                dgvRezultat.Columns[0].Visible = false;
                dgvRezultat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        
        }


        private void cbKriterijum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKriterijum.SelectedItem.ToString() == "Datumu")
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
                kontroler.PrikaziSastanak(o);
            }
            else
            {
                MessageBox.Show("Morate odabrati predmet za prikaz");
                return;
            }
            
           
        }
    }
}
