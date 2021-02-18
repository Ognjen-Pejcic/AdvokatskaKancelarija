using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Kontroleri
{
    class PrikazPredmetaKontroler
    {
        internal void Sacuvaj(int id, string naziv, DateTime datum, string opis, string faza, object vrsta)
        {
            Predmet predmet = new Predmet
            {
                PredmetID = id,
                NazivPremdeta = naziv,
                DatumOtvaranja = datum,
                OpisPredmeta = opis,
                Faza = faza,
                VrstaPostupka = (VrstaPostupka) vrsta
            };
            if (Komunikacija.Instance.SacuvajPredmet(predmet))
            {
                MessageBox.Show("Sistem je uspesno izmenio predmet");

            }
            else
            {
                MessageBox.Show("Sistem nije uspeo da izmenio predmet");

            }
        }
    }
}
