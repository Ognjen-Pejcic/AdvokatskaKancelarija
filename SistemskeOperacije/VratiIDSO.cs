using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiIDSO : ApstraknaGenerickaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {

            return broker.VratiMaxID(domenskiObjekat);
        }

        protected override object Execute(List<DomenskiObjekat> domenskiObjekat)
        {
            throw new NotImplementedException();
        }

        protected override void Validate(DomenskiObjekat domenskiObjekat)
        {
            
        }

        protected override void Validate(List<DomenskiObjekat> domenskiObjekat)
        {
            throw new NotImplementedException();
        }
    }
}
