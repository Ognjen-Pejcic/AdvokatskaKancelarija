﻿using System;
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
    }
}