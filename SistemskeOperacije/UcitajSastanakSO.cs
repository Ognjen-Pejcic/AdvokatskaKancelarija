using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class UcitajSastanakSO : ApstraknaGenerickaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Sastanak sastanak = (Sastanak)domenskiObjekat;
            return broker.VratiJedanJoin(sastanak);
        }



        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Sastanak))
            {
                throw new ArgumentException();
            }
        }

    }
}
