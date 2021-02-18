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
        private void txtLozinka_lostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLozinka.Text))
            {
                txtLozinka.PasswordChar = '\0';
                txtLozinka.Text = "Password".PadLeft(txtLozinka.Text.Length + 5);
            }
        }

        private void txtLozinka_gotFocus(object sender, EventArgs e)
        {
            if (txtLozinka.Text == "Password") { 
            txtLozinka.Text = "";
            txtLozinka.PasswordChar = '*';
            }
        }

        private void txtKorisnickoIMe_lostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKorisnickoIMe.Text))
            {
                txtKorisnickoIMe.Text = "Username".PadLeft(txtKorisnickoIMe.Text.Length + 5);
            }
        }

        private void txtKorisnickoIMe_gotFocus(object sender, EventArgs e)
        {
            if (txtKorisnickoIMe.Text == "Username")
            {
                txtKorisnickoIMe.Text = "";
            }
        }

        private void txtKorisnickoIMe_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
