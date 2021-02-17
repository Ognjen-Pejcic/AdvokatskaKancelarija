using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    
    public class ZapamtiPredmetSO : ApstraknaGenerickaOperacija
    {
        public List<Angazovanje> angazovanja = new List<Angazovanje>();
        public ZapamtiPredmetSO(List<Angazovanje> angazovanja)
        {
            this.angazovanja = angazovanja;
        }
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Predmet predmet= (Predmet)domenskiObjekat;
           
            
            bool odgovor = true;
            if (broker.Sacuvaj(predmet) <= 0)
            {
                odgovor =  false;
            }
            
            //List<DomenskiObjekat> p = broker.VratiSve(new Predmet());
            //foreach(Predmet p1 in p)
            //{
            //    Console.WriteLine(p1.PredmetID + " " + p1.Klijent.KlijentID);
            //}
            foreach(Angazovanje a in angazovanja)
            {
               a.Predmet.PredmetID = broker.VratiMaxID(predmet);
                if (broker.Sacuvaj(a) <= 0) {
                    odgovor = false;
                }
            }
            return odgovor;
        }

        protected override object Execute(List<DomenskiObjekat> domenskiObjekat)
        {
            throw new NotImplementedException();
        }

        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Predmet))
            {
                throw new ArgumentException();
            }
        }

        protected override void Validate(List<DomenskiObjekat> domenskiObjekat)
        {
            throw new NotImplementedException();
        }
    }
}
