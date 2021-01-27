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
    public partial class ZakazivanjeSastanakaFrm : Form
    {

        ZakazivanjeSastanakaKontroler kontroler = new ZakazivanjeSastanakaKontroler();
        public ZakazivanjeSastanakaFrm()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kontroler.Sacuvaj();
        }

        private void btnDodaj_Load(object sender, EventArgs e)
        {
            cbKlijent.DataSource = Komunikacija.Instance.PrikaziKlijente();
            cbAdvokat.DataSource = Komunikacija.Instance.PrikaziAdvokate();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kontroler.Dodaj(cbAdvokat.SelectedItem, cbKlijent.SelectedItem, dtpDatum.Value);
            dgvSastanci.DataSource = kontroler.sastanci;
            dgvSastanci.Columns["SastanakID"].Visible = false;
        }
    }
}
