using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //IDDDDDD
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
        }
    }
}
