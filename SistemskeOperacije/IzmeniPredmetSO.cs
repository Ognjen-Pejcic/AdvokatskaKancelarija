﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class IzmeniPredmetSO : OpstaSistemskaOperacija
    {
        protected override object Execute(DomenskiObjekat domenskiObjekat)
        {
            Predmet predmet= (Predmet)domenskiObjekat;
            if (broker.Azuriraj(predmet) == 1)
            {
                return true;
            }
            return false;
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
