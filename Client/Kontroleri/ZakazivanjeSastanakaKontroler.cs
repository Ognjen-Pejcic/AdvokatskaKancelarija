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
            if(advokat==null || klijent == null)
            {
                MessageBox.Show("Svi podaci su obavezni");
                return;
            }
            if (datumVreme < DateTime.Now)
            {
                MessageBox.Show("Ne mozete da zakazete sastanak u proslom terminu");
                return;
            }
            foreach (Sastanak s in sastanci)
            {
                if (s.Advokat == advokat && s.Klijent == klijent && s.DatumIVremeSastanka == datumVreme)
                {
                    MessageBox.Show("Sastanak sa ovim podacima ste vec uneli");
                    return;
                }
               
            }
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
