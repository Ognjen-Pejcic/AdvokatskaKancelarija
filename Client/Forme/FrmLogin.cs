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

namespace Client
{
    public partial class FrmLogin : Form
    {
        LoginKontroler loginKontroler = new LoginKontroler();
        public FrmLogin()
        {
            ConnectToServer();       
            InitializeComponent();
        }

        private void ConnectToServer()
        {
            if (Komunikacija.Instance.Connect())
            {
                MessageBox.Show("Uspesno povezivanje");
            }
            else
            {
                MessageBox.Show("Neuspesno povezivanje");
                Environment.Exit(0);
            }


        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            loginKontroler.Login(txtKorisnickoIMe.Text, txtLozinka.Text);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                Komunikacija.Instance.PrekiniKomunikaciju();
            
        }
    }
}
