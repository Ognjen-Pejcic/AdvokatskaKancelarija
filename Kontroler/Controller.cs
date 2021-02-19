using DbBroker;
using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroler
{
    public class Controller
    {
        private Broker broker = new Broker();
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public List<Sekretar> VratiSekretare()
        {
            ApstraknaGenerickaOperacija operacija = new VratiSekretareSO();
            List<Sekretar> sekretari = (List<Sekretar>)operacija.ExecuteSO(new Sekretar());
            return sekretari;
        }

        public bool SacuvajPredmet(Predmet predmet, List<Angazovanje> angazovanja)
        {
            ApstraknaGenerickaOperacija operacija = new ZapamtiPredmetSO(angazovanja);
            return (bool)operacija.ExecuteSO(predmet);
        }
        public bool SacuvajKlijenta(Klijent klijent)
        {
            ApstraknaGenerickaOperacija operacija = new ZapamtiKlijentaSO();
            return (bool)operacija.ExecuteSO(klijent);
        }
        public bool ZakaziSastanke(List<Sastanak> sastanci, Sastanak sastanak)
        {
            ApstraknaGenerickaOperacija operacija = new ZakaziSastankeSO(sastanci);
           // List<DomenskiObjekat> lista = new List<DomenskiObjekat>();
            //foreach(Sastanak s  in sastanci)
            //{
            //    lista.Add(s);
            //}
            return (bool)operacija.ExecuteSO(sastanak);
        }
        public List<Sastanak> NadjiSastanke(string kriterijumPretrage, string tekstPretrage, DateTime datum, Sastanak sastanak)
        {
            ApstraknaGenerickaOperacija operacija = new NadjiSastankeSO();
            sastanak.PostaviVrednostiPretrage(kriterijumPretrage, tekstPretrage, datum);
            List < Sastanak > sastanci = (List<Sastanak>)operacija.ExecuteSO(sastanak);
            return sastanci;
        }
        public List<Klijent> NadjiKlijente(string kriterijumPretrage, string textPretrage, Klijent klijent)
        {
            ApstraknaGenerickaOperacija operacija = new NadjiKlijenteSO();
            klijent.PostaviVrednostiPretrage(kriterijumPretrage, textPretrage);
            List<Klijent> klijenti= (List<Klijent>)operacija.ExecuteSO(klijent);
            return klijenti;
        }
        public List<Predmet> NadjiPredmete(string kriterijumPretrage, string textPretrage, DateTime datum, Predmet predmet)
        {
            ApstraknaGenerickaOperacija operacija = new NadjiPredmeteSO();
            predmet.PostaviVrednostiPretrage(kriterijumPretrage, textPretrage, datum);
            List<Predmet> predmeti= (List<Predmet>)operacija.ExecuteSO(predmet);
            return predmeti;
        }
        public List<Advokat> VratiListuAdvokata()
        {
            ApstraknaGenerickaOperacija operacija = new VratiListuAdvokataSO();
            List<Advokat> advokati = (List<Advokat>)operacija.ExecuteSO(new Advokat());
            return advokati;
        }
        public List<Klijent> VratiListuKlijenata()
        {
            ApstraknaGenerickaOperacija operacija = new VratiListuKlijnataSO();
            List<Klijent> klijenti = (List<Klijent>)operacija.ExecuteSO(new Klijent());
            return klijenti;
        }

        public List<VrstaPostupka> VratiListuVrsta()
        {
            ApstraknaGenerickaOperacija operacija = new VratiListuVrstaSO();
            List<VrstaPostupka> vrste = (List<VrstaPostupka>)operacija.ExecuteSO(new VrstaPostupka());
            return vrste;
        }

        public Klijent UcitajKlijenta(Klijent klijent)
        {
            ApstraknaGenerickaOperacija operacija = new UcitajKlijentaSO();
            return (Klijent)operacija.ExecuteSO(klijent);
        }

        public int VratiID(DomenskiObjekat domenskiObjekat)
        {
            ApstraknaGenerickaOperacija operacija = new VratiIDSO();
            return (int)operacija.ExecuteSO(domenskiObjekat);
        }

        public Sastanak UcitajSastanak(Sastanak sastanak)
        {
            ApstraknaGenerickaOperacija operacija = new UcitajSastanakSO();
            return (Sastanak)operacija.ExecuteSO(sastanak);
        }
        public Predmet UcitajPredmet(Predmet predmet)
        {
            ApstraknaGenerickaOperacija operacija = new UcitajPredmetSO();
            return (Predmet)operacija.ExecuteSO(predmet);
        }


        public bool ArhivirajPredmet(Predmet predmet)
        {
            ApstraknaGenerickaOperacija operacija = new ArhivirajPredmetSO();
            return (bool)operacija.ExecuteSO(predmet);
        }

        public bool IzmeniKlijena(Klijent klijent)
        {
            ApstraknaGenerickaOperacija operacija = new IzmeniKlijentaSO();
            return (bool)operacija.ExecuteSO(klijent);
        }

        public bool IzmeniPredmet(Predmet predmet)
        {
            ApstraknaGenerickaOperacija operacija = new IzmeniPredmetSO();
            return (bool)operacija.ExecuteSO(predmet);
        }
    }
}
