using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Kontroleri
{
    public class DodajKlijentaKontroler
    {
        internal void Dodaj(string jmbg, string ime, string prezime, string adresa, string telefon)
        {
            Klijent klijent = new Klijent
            {
                JMBGKlijenta = jmbg,
                ImeKlijenta = ime,
                Prezime = prezime,
                AdresaKlijenta = adresa,
                TelefonKlijenta = telefon
            };
            if (Komunikacija.Instance.DodajKlijenta(klijent))
            {
                MessageBox.Show("Sistem je zapamtio klijenta");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti klijeta");
            }
        }
    }
}
