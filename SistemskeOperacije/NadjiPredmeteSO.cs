using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
namespace SistemskeOperacije
{
    public class NadjiPredmeteSO : ApstraknaGenerickaOperacija
    {
      
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Predmet predmet = (Predmet)domenskiObjekat;
            List<Predmet> predmeti= broker.Pronadji(domenskiObjekat).OfType<Predmet>().ToList();
            return predmeti;
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
