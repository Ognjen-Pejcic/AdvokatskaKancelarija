using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Kontroleri
{
    public class DodajKlijentaKontroler
    {
        internal void Dodaj(string jmbg, string ime, string prezime, string adresa, string telefon)
        {
            if(String.IsNullOrEmpty(jmbg) || String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(prezime) || String.IsNullOrEmpty(adresa) || String.IsNullOrEmpty(telefon))
            {   
                MessageBox.Show("Svi podaci su obavezni");
                return;
            }
            Regex r = new Regex("^(0[1-9]|[1-2][0-9]|3[0-1])(0[1-9]|1[0-2])[0-9]{9}$");
            if (!r.IsMatch(jmbg)) {
                MessageBox.Show("Unesite validan JMBG");
                return;
            }
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
