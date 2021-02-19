using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiSekretareSO : ApstraknaGenerickaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Sekretar sekretar= (Sekretar)domenskiObjekat;
            List<Sekretar> sekretari = broker.VratiSve(domenskiObjekat).OfType<Sekretar>().ToList();
            return sekretari;
            
        }


        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Sekretar))
            {
                throw new ArgumentException();
            }
        }

    }
}
