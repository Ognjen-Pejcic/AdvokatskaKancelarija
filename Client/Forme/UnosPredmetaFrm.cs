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
    public partial class UnosPredmetaFrm : Form
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


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           
            kontroler.Angazuj(cbAdvokati.SelectedItem);
            dgvAdvokati.DataSource = kontroler.angazovaniAdvokati;
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kontroler.Sacuvaj(cbKlijent.SelectedItem, txtNaziv.Text, dtpDatum.Value, chBArhiviran.Checked ? true :false , txtOpis.Text, cbFaza.SelectedItem, cbVrsta.SelectedItem);
        }
    }
}
