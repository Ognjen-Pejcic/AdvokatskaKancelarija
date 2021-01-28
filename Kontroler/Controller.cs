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
        public bool ZakaziSastanke(List<Sastanak> sastanci)
        {
            ApstraknaGenerickaOperacija operacija = new ZakaziSastankeSO();
            List<DomenskiObjekat> lista = new List<DomenskiObjekat>();
            foreach(Sastanak s  in sastanci)
            {
                lista.Add(s);
            }
            return (bool)operacija.ExecuteSO(lista);
        }
        public List<Sastanak> NadjiSastanke(Sastanak sastanak)
        {
            ApstraknaGenerickaOperacija operacija = new NadjiSastankeSO();
            List < Sastanak > sastanci = (List<Sastanak>)operacija.ExecuteSO(sastanak);
            return sastanci;
        }
        public List<Klijent> NadjiKlijente(Klijent klijent)
        {
            ApstraknaGenerickaOperacija operacija = new NadjiKlijenteSO();
            List<Klijent> klijenti= (List<Klijent>)operacija.ExecuteSO(klijent);
            return klijenti;
        }
        public List<Predmet> NadjiPredmete(Predmet predmet)
        {
            ApstraknaGenerickaOperacija operacija = new NadjiSastankeSO();
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
            ApstraknaGenerickaOperacija operacija = new UcitajKlijentaSO();
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
    }
}
