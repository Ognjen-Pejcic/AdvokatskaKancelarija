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
    public partial class PrikazPredmetaFrm : Form
    {
        int id;
        public PrikazPredmetaFrm(int predmetID)
        {
            this.id = predmetID;
            InitializeComponent();
        }

        private void PrikazPredmetaFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
