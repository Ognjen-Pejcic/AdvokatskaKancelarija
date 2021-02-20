using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class ZakaziSastankeSO : OpstaSistemskaOperacija
    {
        List<Sastanak> sastanci;
        public ZakaziSastankeSO(List<Sastanak> sastanci)
        {
            this.sastanci = sastanci;
        }
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
           
            bool signal = true;
            foreach(Sastanak s in sastanci) { 
            if (!(broker.Sacuvaj(s) > 0))
            {
                    signal = false;
            }
            }
            return signal;
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
