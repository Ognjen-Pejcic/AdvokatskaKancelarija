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
        string username;
        public FrmGlavna(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void unosNovogKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosKlijentaFrm unosKlijenta = new UnosKlijentaFrm();
            //unosKlijenta.ShowDialog();
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            textBox1.Text = username;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var button in panel1.Controls.OfType<Button>())
            {
                if (button != button1)
                {
                    button.BackColor = Color.FromArgb(24, 30, 54);
                    button.FlatAppearance.BorderSize = 0;
                }
            }

            UnosKlijentaFrm frm = new UnosKlijentaFrm();
            pnlGlavni.Controls.Clear();
            frm.Parent = pnlGlavni;
            frm.Dock = DockStyle.Fill;

            button1.BackColor = Color.FromArgb(24, 60, 54);
            button1.FlatAppearance.BorderSize = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var button in panel1.Controls.OfType<Button>())
            {
                if (button != button2)
                {
                    button.BackColor = Color.FromArgb(24, 30, 54);
                    button.FlatAppearance.BorderSize = 0;
                }
            }
            ZakazivanjeSastanakaFrm frm = new ZakazivanjeSastanakaFrm();
            pnlGlavni.Controls.Clear();
            frm.Parent = pnlGlavni;
            frm.Dock = DockStyle.Fill;

            button2.BackColor = Color.FromArgb(24, 60, 54);
            button2.FlatAppearance.BorderSize = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var button in panel1.Controls.OfType<Button>())
            {
                if (button != button3)
                {
                    button.BackColor = Color.FromArgb(24, 30, 54);
                    button.FlatAppearance.BorderSize = 0;
                }
            }
            UnosPredmetaFrm frm = new UnosPredmetaFrm();
            pnlGlavni.Controls.Clear();
            frm.Parent = pnlGlavni;
            frm.Dock = DockStyle.Fill;

            button3.BackColor = Color.FromArgb(24, 60, 54);
            button3.FlatAppearance.BorderSize = 1;
        }

        private void btnPretragaKlijenta_Click(object sender, EventArgs e)
        {

            foreach (var button in panel1.Controls.OfType<Button>())
            {
                if (button != btnPretragaKlijenta)
                {
                    button.BackColor = Color.FromArgb(24, 30, 54);
                    button.FlatAppearance.BorderSize = 0;
                }
            }
            FrmPretragaKlijenata frm = new FrmPretragaKlijenata();
            pnlGlavni.Controls.Clear();
            frm.Parent = pnlGlavni;
            frm.Dock = DockStyle.Fill;

            btnPretragaKlijenta.BackColor = Color.FromArgb(24, 60, 54);
            btnPretragaKlijenta.FlatAppearance.BorderSize = 1;
        }

        private void btnPretragaPredmeta_Click(object sender, EventArgs e)
        {
            foreach (var button in panel1.Controls.OfType<Button>())
            {
                if (button != btnPretragaPredmeta)
                {
                    button.BackColor = Color.FromArgb(24, 30, 54);
                    button.FlatAppearance.BorderSize = 0;
                }
            }
            PretragaPredmetaFrm frm = new PretragaPredmetaFrm();
            pnlGlavni.Controls.Clear();
            frm.Parent = pnlGlavni;
            frm.Dock = DockStyle.Fill;
            
            btnPretragaPredmeta.BackColor = Color.FromArgb(24, 60, 54);
            btnPretragaPredmeta.FlatAppearance.BorderSize = 1;
        }

        private void btnPretragaSastanaka_Click(object sender, EventArgs e)
        {
            foreach (var button in panel1.Controls.OfType<Button>())
            {
                if (button != btnPretragaSastanaka)
                {
                    button.BackColor = Color.FromArgb(24, 30, 54);
                    button.FlatAppearance.BorderSize = 0;
                }
            }
            PretragaSastanakaFrm frm = new PretragaSastanakaFrm();
            pnlGlavni.Controls.Clear();
            frm.Parent = pnlGlavni;
            frm.Dock = DockStyle.Fill;
            
            btnPretragaSastanaka.BackColor =  Color.FromArgb(24, 60, 54);
            btnPretragaSastanaka.FlatAppearance.BorderSize = 1;
            
        }

        private void FrmGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Komunikacija.Instance.IzlogujSe();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
