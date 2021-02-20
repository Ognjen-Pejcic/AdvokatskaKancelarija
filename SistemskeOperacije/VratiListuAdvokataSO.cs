using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiListuAdvokataSO : OpstaSistemskaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Advokat advokat = (Advokat)domenskiObjekat;
            List<Advokat> advokati = broker.VratiSve(domenskiObjekat).OfType<Advokat>().ToList();
            return advokati;
        }

        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Advokat))
            {
                throw new ArgumentException();
            }
        }

    }
}
