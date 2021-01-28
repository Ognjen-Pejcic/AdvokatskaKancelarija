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
    public class UnosPredmetaKontroler
    {
        public BindingList<Advokat> angazovaniAdvokati = new BindingList<Advokat>();
        public List<Angazovanje> angazovanja = new List<Angazovanje>();

        internal void Angazuj(object advokat)
        {
            angazovaniAdvokati.Add((Advokat)advokat);
           
        }

        internal void Sacuvaj(object klijent, string naziv, DateTime datumVreme, bool arhiviran, string opis, object faza, object vrsta)
        {
            Predmet predmet = new Predmet
            {
                PredmetID = Komunikacija.Instance.VratiMaxID(new Predmet())+1,
                Klijent = (Klijent)klijent,
                NazivPremdeta = naziv,
                DatumOtvaranja = datumVreme, 
                Arhiviran  = arhiviran,
                OpisPredmeta = opis, 
                Faza = (String)faza,
                VrstaPostupka = (VrstaPostupka)vrsta
            };
        
            foreach (Advokat advokat in angazovaniAdvokati)
            {
                angazovanja.Add(new Angazovanje
                {
                    Advokat =advokat,
                    Predmet = predmet
                });
            }
            if (Komunikacija.Instance.DodajPredmet(predmet, angazovanja))
            {
                MessageBox.Show("Sistem je sacuvao predmet");
            }
            else
            {
                MessageBox.Show("Sistem nije sacuvao predmet");
            }
        }
    }
}
