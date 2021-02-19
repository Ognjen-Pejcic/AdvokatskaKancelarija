using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Kontroleri
{
    public class PrikazKlijentaKontroler
    {
        internal void Izmeni(int id, string jbmg, string ime, string prezime, string adresa, string telefon)
        {
            Klijent klijent = new Klijent
            {
                KlijentID = id,
                JMBGKlijenta = jbmg,
                ImeKlijenta =ime,
                Prezime = prezime,
                AdresaKlijenta=  adresa,
                TelefonKlijenta = telefon
            };
            if (Komunikacija.Instance.IzmeniKlienta(klijent))
            {
                MessageBox.Show("Sistem je zapamtio klijenta");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti podakte o klijentu");
            }
           
        }
    }
}
