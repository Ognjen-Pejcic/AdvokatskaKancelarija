using Client.Kontroleri;
using Domen;
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
    public partial class UnosKlijentaFrm : UserControl
    {
        DodajKlijentaKontroler kontroler = new DodajKlijentaKontroler();
        public UnosKlijentaFrm()
        {
            InitializeComponent();
        }

        private void UnosKlijentaFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kontroler.Dodaj(txtJMBG.Text, txtIme.Text, txtPrezime.Text, txtTelefon.Text, txtAdresa.Text);
        }
    }
}
