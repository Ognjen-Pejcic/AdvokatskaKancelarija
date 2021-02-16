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
    public class PretragaKlijenataKontroler
    {
        internal List<Klijent> PrikaziKlijente(string kriterijum, string text, bool provera)
        {
            
                List<Klijent> lista = Komunikacija.Instance.VratiKlijente(kriterijum,text);
            if (provera) { 
            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da nadje klijente po zadatoj vrednosti");
                    return null;
            }
            else
            {
               
                MessageBox.Show("Sistem je nasao klijente po zadatoj vrednosti");
                    return lista;
                }
            }
            else
            {
                return lista;
            }
            
        }

        internal void PrikaziKlijenta(object o)
        {
        
            Klijent k = (Klijent)o;
            Klijent klijent = Komunikacija.Instance.PrikaziKlijenta(k.KlijentID);
            if (klijent != null) { 
            PrikazKlijentaFRM frm = new PrikazKlijentaFRM(klijent.KlijentID, klijent.JMBGKlijenta, klijent.ImeKlijenta, klijent.Prezime, klijent.AdresaKlijenta, klijent.TelefonKlijenta); 
            frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da prikaze izabrani predmet");
            }
        }
    }
}
