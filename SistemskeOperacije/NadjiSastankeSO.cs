using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class NadjiSastankeSO : OpstaSistemskaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Sastanak sastanak= (Sastanak)domenskiObjekat;
            List<Sastanak> sastanci = broker.VratiSveJoinWhere(domenskiObjekat).OfType<Sastanak>().ToList();
            return sastanci;
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
