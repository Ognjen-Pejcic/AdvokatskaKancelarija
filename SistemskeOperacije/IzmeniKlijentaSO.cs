using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class IzmeniKlijentaSO : OpstaSistemskaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Klijent klijent= (Klijent)domenskiObjekat;
            if (broker.Azuriraj(klijent) == 1)
            {
                return true;
            }
            return false;
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
