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
        internal object PrikaziSastanke(string kriterijum, string text, bool provera)
        {
            List<Sastanak> lista = Komunikacija.Instance.VratiSastanke(kriterijum, text);
            if (provera)
            {
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
            else
            {
                return lista;
            }
        }

        internal object PrikaziSastanke(string v, DateTime value, bool provera)
        {
            List<Sastanak> lista = Komunikacija.Instance.VratiSastanke(v, value);
            if (provera)
            {
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
            else
            {
                return lista;
            }
        }
    }
}
