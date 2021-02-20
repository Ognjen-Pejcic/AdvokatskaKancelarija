using Client.Forme;
using Domen;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Kontroleri
{
    public class PretragaPredmetaKontroler
    {
        internal object PrikaziPrdemete(string kriterijum, string text, bool provera)
        {
            //if(kriterijum=="Datumu otvaranja")
            //{
            //    if(!DateTime.TryParseExact(text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime _datum))
            //    {
            //        MessageBox.Show("Unesite datum u formatu MM/dd/yyyy");
            //        return null;
            //    }
            //}
            List<Predmet> lista = Komunikacija.Instance.VratiPredmete(kriterijum, text);
            if (provera)
            {
                if (lista == null)
                {
                    MessageBox.Show("Sistem ne moze da nadje predmete po zadatoj vrednosti");
                    return null;
                }
                else
                {

                    MessageBox.Show("Sistem je nasao predmete po zadatoj vrednosti");
                    return lista;
                }
            }
            else
            {
                return lista;
            }

        }

        internal object PrikaziPrdemete(string v, DateTime value, bool provera)
        {
            
            
            List<Predmet> lista = Komunikacija.Instance.VratiPredmete(v, value);
            if (provera)
            {
                if (lista == null)
                {
                    MessageBox.Show("Sistem ne moze da nadje predmete po zadatoj vrednosti");
                    return null;
                }
                else
                {

                    MessageBox.Show("Sistem je nasao predmete po zadatoj vrednosti");
                    return lista;
                }
            }
            else
            {
                return lista;
            }
        }

        internal void PrikaziPredmet(object o)
        {

            try { 
               Predmet predmet = (Predmet)o;
                Predmet p = Komunikacija.Instance.VratiPremdet(predmet.PredmetID);
                PrikazPredmetaFrm frm = new PrikazPredmetaFrm(p.PredmetID, p.Klijent, p.DatumOtvaranja, p.Arhiviran, p.NazivPremdeta, p.OpisPredmeta, p.VrstaPostupka, p.Faza, p.Angazovanja);
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Sistem ne moze da prikaze izabrani predmet");
            }
               
            
        }

        internal void ArhivirajPredmet(object o)
        {
            try
            {
                Predmet predmet = (Predmet)o;
                if(Komunikacija.Instance.ArhivirajPredmet(predmet))
                {
                    MessageBox.Show("Sistem je uspesno arhivirao predmet");
                }
                else
                {
                    MessageBox.Show("Sistem nije uspeo da arhivira predmet");
                }
                
            }
            catch
            {
                MessageBox.Show("Sistem ne moze da prikaze izabrani predmet");
            }
        }
    }
}
                                