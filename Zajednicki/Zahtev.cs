using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public Sekretar Sekretar { get; set; }
        public Klijent Klijent { get; set; }
    }

    public enum Operacija
    {
        Login,
        DodajKlijenta
    }
}
