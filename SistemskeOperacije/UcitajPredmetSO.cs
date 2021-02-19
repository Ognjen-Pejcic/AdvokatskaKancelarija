using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class UcitajPredmetSO : ApstraknaGenerickaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Predmet predmet = (Predmet)domenskiObjekat;
            Predmet rezultat = (Predmet)broker.VratiJedanJoin(predmet);
            // rezultat.Angazovanja = broker.VratiSveJoinWhere
            return rezultat;
        }

        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Predmet))
            {
                throw new ArgumentException();
            }
        }


    }
}
