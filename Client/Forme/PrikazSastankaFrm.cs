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
    public partial class PrikazSastankaFrm : Form
    {
        private object advokat;
        private object klijent;
        private DateTime datumIVremeSastanka;

        public PrikazSastankaFrm()
        {
            InitializeComponent();
        }

        public PrikazSastankaFrm(object advokat, object klijent, DateTime datumIVremeSastanka)
        {
            this.advokat = advokat;
            this.klijent = klijent;
            this.datumIVremeSastanka = datumIVremeSastanka;
            InitializeComponent();
        }

        private void PrikazSastankaFrm_Load(object sender, EventArgs e)
        {
            textBox1.Text = advokat.ToString();
            textBox2.Text = klijent.ToString();
            dtpDatum.Value = datumIVremeSastanka;
        }
    }
}
