using Client.Forme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Kontroleri
{
    public class LoginKontroler
    {
        internal void Login(string korisnickoime, string lozinka)
        {
            if(String.IsNullOrEmpty(korisnickoime) || String.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Sva polja su obavezna");
                return; 
            }
            if(Komunikacija.Instance.Login(korisnickoime, lozinka))
            {
                MessageBox.Show("Uspesno prijavljivanje");
                FrmGlavna glavna = new FrmGlavna();
                glavna.ShowDialog();
            }
            else
            {
                MessageBox.Show("Korisnik ne postoji ili je vec prijavljen");
            }
        }
    }

}
