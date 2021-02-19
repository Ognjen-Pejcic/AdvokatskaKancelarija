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
            foreach(Advokat a in angazovaniAdvokati)
            {
                if(a==advokat)
                {
                    MessageBox.Show("Advokat je vec angazovan");
                    return;
                }
            }
            angazovaniAdvokati.Add((Advokat)advokat);
           
        }

        internal void Sacuvaj(object klijent, string naziv, DateTime datumVreme, bool arhiviran, string opis, object faza, object vrsta)
        {
            if(klijent==null || String.IsNullOrEmpty(naziv) || datumVreme == null || faza==null || vrsta == null)
            {
                MessageBox.Show("Svi podaci su obavezni osim opisa");
                MessageBox.Show("Sistem ne moze da zapamti predmet");
                return;
            }
            Predmet predmet = new Predmet
            {
                //PredmetID = Komunikacija.Instance.VratiMaxID(new Predmet())+1,
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
                MessageBox.Show("Sistem je zapamtio predmet");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da sacuva predmet");
            }
            angazovaniAdvokati.Clear();
            angazovanja.Clear();
        }
    }
}
