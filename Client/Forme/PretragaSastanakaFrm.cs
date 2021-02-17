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
            if (cbKriterijum.SelectedItem.ToString() != "Datumu")
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    dgvRezultat.DataSource = null;
                    return;

                }
                o = kontroler.PrikaziSastanke(cbKriterijum.SelectedItem.ToString(), textBox1.Text, provera);
            }
            else
            {
                o = kontroler.PrikaziSastanke(cbKriterijum.SelectedItem.ToString(), dateTimePicker1.Value, provera);
            }
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
