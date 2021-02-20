using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class NadjiKlijenteSO : OpstaSistemskaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Klijent klijent = (Klijent)domenskiObjekat;
            List<Klijent> klijenti = broker.Filtriraj(domenskiObjekat).OfType<Klijent>().ToList();
            return klijenti;
        }


        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Klijent))
            {
                throw new ArgumentException();
            }
        }


    }
}
