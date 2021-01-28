using Domen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije
{
    public class VratiListuVrstaSO : ApstraknaGenerickaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
          
            List<VrstaPostupka> vrste = broker.VratiSve(domenskiObjekat).OfType<VrstaPostupka>().ToList();
            return vrste;
        }

        protected override object Execute(List<DomenskiObjekat> domenskiObjekat)
        {
            throw new System.NotImplementedException();
        }

        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is VrstaPostupka))
            {
                throw new ArgumentException();
            }
        }

        protected override void Validate(List<DomenskiObjekat> domenskiObjekat)
        {
            throw new System.NotImplementedException();
        }
    }
}