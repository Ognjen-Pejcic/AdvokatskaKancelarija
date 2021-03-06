﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
namespace SistemskeOperacije
{
    public class NadjiPredmeteSO : OpstaSistemskaOperacija
    {
      
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Predmet predmet = (Predmet)domenskiObjekat;
            List<Predmet> predmeti= broker.VratiSveJoinWhere(domenskiObjekat).OfType<Predmet>().ToList();
            return predmeti;
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
