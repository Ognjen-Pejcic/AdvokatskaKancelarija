using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        Server server = new Server();
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            Thread nit =  new Thread(server.Start);
            nit.IsBackground = true;
            nit.Start();
            progressBar1.Value = 100 ;
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            progressBar1.Value = 0;
        }
    }
}
