using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class UcitajKlijentaSO : ApstraknaGenerickaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Klijent klijent = (Klijent)domenskiObjekat;
            return broker.Pronadji(klijent);
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
