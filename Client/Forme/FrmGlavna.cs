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
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void unosNovogKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosKlijentaFrm unosKlijenta = new UnosKlijentaFrm();
            unosKlijenta.ShowDialog();
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnosKlijentaFrm frm = new UnosKlijentaFrm();
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZakazivanjeSastanakaFrm frm = new ZakazivanjeSastanakaFrm();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnosPredmetaFrm frm = new UnosPredmetaFrm();
            frm.ShowDialog();
        }

        private void btnPretragaKlijenta_Click(object sender, EventArgs e)
        {
            FrmPretragaKlijenata frm = new FrmPretragaKlijenata();
            frm.ShowDialog();
        }

        private void btnPretragaPredmeta_Click(object sender, EventArgs e)
        {
            PretragaPredmetaFrm frm = new PretragaPredmetaFrm();
            frm.ShowDialog();
        }

        private void btnPretragaSastanaka_Click(object sender, EventArgs e)
        {

        }
    }
}
