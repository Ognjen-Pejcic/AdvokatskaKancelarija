using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class UcitajPredmetSO : OpstaSistemskaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Predmet predmet = (Predmet)domenskiObjekat;
            Predmet rezultat = (Predmet)broker.VratiJedanJoin(predmet);
            Angazovanje a = new Angazovanje();
            a.Predmet = new Predmet
            {
                PredmetID = rezultat.PredmetID
            };
            List<DomenskiObjekat> aa = broker.VratiSveJoinWhere(a);
            List<Angazovanje> angazovanja = new List<Angazovanje>();
            foreach(Angazovanje ang in aa)
            {
                angazovanja.Add(ang);
            }
            rezultat.Angazovanja = angazovanja;
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
