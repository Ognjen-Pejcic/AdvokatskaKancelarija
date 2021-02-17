using Client.Forme;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Kontroleri
{
    public class PretragaSastanakaKontroler
    {
        internal object PrikaziSastanke(string kriterijum, string text)
        {
            List<Sastanak> lista = Komunikacija.Instance.VratiSastanke(kriterijum, text);
            
                if (lista == null)
                {
                    MessageBox.Show("Sistem ne moze da nadje sastanke po zadatoj vrednosti");
                    return null;
                }
                else
                {

                    MessageBox.Show("Sistem je nasao sastanke po zadatoj vrednosti");
                    return lista;
                }
            
            
        }

        internal object PrikaziSastanke(string v, DateTime value)
        {
            List<Sastanak> lista = Komunikacija.Instance.VratiSastanke(v, value);
          
                if (lista == null)
                {
                    MessageBox.Show("Sistem ne moze da nadje sastanke po zadatoj vrednosti");
                    return null;
                }
                else
                {

                    MessageBox.Show("Sistem je nasao sastanke po zadatoj vrednosti");
                    return lista;
                }
            
           
        }

        internal void PrikaziSastanak(object o)
        {
            Sastanak s = (Sastanak)o;
            Sastanak sastanak = Komunikacija.Instance.VratiSastanak(s.SastanakID);
            PrikazSastankaFrm frm = new PrikazSastankaFrm(sastanak.Advokat, sastanak.Klijent, sastanak.DatumIVremeSastanka);
            frm.ShowDialog();
        }
    }
}
