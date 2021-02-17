using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public BindingList<Sastanak> Sastanci { get; set; }
        public DomenskiObjekat DomenskiObjekat { get; set; }
        public Predmet Predmet { get; set; }
        public List<Angazovanje> Angazovanja { get; set; }
        public string KriterijumPretrage { get; set; }
        public string TekstPretrage { get; set; }
        public int ID { get; set; }
        public DateTime Datum { get; set; }
    }

    public enum Operacija
    {
        Login,
        DodajKlijenta,
        VratiAdvokate,
        VratiKlijente,
        ZakaziSastanke,
        VratiVrste,
        VratiID,
        DodajPredmet,
        PretraziKlijente,
        VratiKlijenta,
        IzmeniKlijenta,
        PretraziPredmete,
        ArhivirajPredmet,
        PretraziSastanke,
        VratiPredmet,
        VratiSastanak
    }
}
