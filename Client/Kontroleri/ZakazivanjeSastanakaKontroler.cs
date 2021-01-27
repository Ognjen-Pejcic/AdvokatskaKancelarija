using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Kontroleri
{
    public class ZakazivanjeSastanakaKontroler
    {
        public BindingList<Sastanak> sastanci = new BindingList<Sastanak>();
        internal void Dodaj(object advokat, object klijent, DateTime datumVreme)
        {
            sastanci.Add(new Sastanak
            {
                Advokat = (Advokat)advokat,
                Klijent = (Klijent)klijent,
                DatumIVremeSastanka = datumVreme
            });
            
        }

        internal void Sacuvaj()
        {
            if (Komunikacija.Instance.Sacuvaj(sastanci))
            {
                MessageBox.Show("Sistem je zapamtio sastanke");

            }
            else
            {
                MessageBox.Show("Sistem nije uspeo da zapamti sastanke");
            }
        }
    }
}
