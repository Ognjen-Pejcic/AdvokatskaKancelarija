using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Zajednicki;

namespace Client
{
    public class Komunikacija
    {
        private static Komunikacija instance;
        private Socket klijentskiSoket;
        private Sekretar logovaniSekretar;
        

        private NetworkStream stream;
        private BinaryFormatter formatter =  new BinaryFormatter();
        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }

        internal bool SacuvajPredmet(Predmet predmet)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.IzmeniPredmet;
            zahtev.Predmet = predmet;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.PredmetUspesnoDodat)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        internal bool Login(string korisnickoime, string lozinka)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.Login;
            Sekretar s = new Sekretar
            {
                KorisnickoIme = korisnickoime,
                Lozinka = lozinka
            };
            zahtev.Sekretar = s;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.UspesnoPrijavljen)
            {
                logovaniSekretar = s;
                return true;
            }
            return false;
        }

        internal void PrekiniKomunikaciju()
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.Prekini;
                klijentskiSoket.Shutdown(SocketShutdown.Both);
                klijentskiSoket.Close();
            }
            catch
            {

            }
           
        }

        internal bool Connect()
        {
            try
            {
                if (klijentskiSoket == null || !klijentskiSoket.Connected)
                {
                    klijentskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    klijentskiSoket.Connect("localhost", 9000);
                    stream = new NetworkStream(klijentskiSoket);

                }
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        internal void IzlogujSe()
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Sekretar = logovaniSekretar;
                zahtev.Operacija = Operacija.IzlogujSe;
                formatter.Serialize(stream, zahtev);
            }
            catch
            {

            }
            
        }

        internal bool IzmeniKlienta(Klijent klijent)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.IzmeniKlijenta;
            zahtev.Klijent = klijent;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if(odgovor.Signal == Signal.KlijentUspesnoIzmenjen)
            {
                return true;
            }
            return false;
        }

        internal Predmet VratiPremdet(int predmetID)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiPredmet;
            zahtev.ID = predmetID;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.Predmet;
        }



        internal List<VrstaPostupka> PrikaziVrste()
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiVrste;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.ListaVrsta;
        }

        internal bool ArhivirajPredmet(Predmet predmet)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.ArhivirajPredmet;
            zahtev.Predmet = predmet;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.PredmetUspesnoArhiviran)
            {
                return true;
            }
            else return false;
        }

        internal Sastanak VratiSastanak(int sastanakID)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiSastanak;
            zahtev.ID = sastanakID;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.Sastanak;
        }

        internal Klijent PrikaziKlijenta(int id)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiKlijenta;
            zahtev.ID = id;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.Klijent;
        }
       

        internal int VratiMaxID(DomenskiObjekat domenskiObjekat)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiID;
            zahtev.DomenskiObjekat = domenskiObjekat;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.ID;
        }

        internal List<Advokat> PrikaziAdvokate()
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiAdvokate;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.ListaAdvokata;
        }

        internal bool DodajPredmet(Predmet predmet, List<Angazovanje> angazovanja)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.DodajPredmet;
            zahtev.Predmet = predmet;
            zahtev.Angazovanja = angazovanja;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if(odgovor.Signal == Signal.PredmetUspesnoDodat)
            {
                return true;
            }
            return false;
        }

        internal bool Sacuvaj(BindingList<Sastanak> sastanci)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Sastanci = sastanci;
            zahtev.Operacija = Operacija.ZakaziSastanke;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if(odgovor.Signal == Signal.SastanciUspesnoZakazani)
            {
                return true;
            }
            return false;
        }

        internal List<Klijent> PrikaziKlijente()
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiKlijente;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.ListaKlijenata;
        }

        internal bool DodajKlijenta(Klijent klijent)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.DodajKlijenta;
            zahtev.Klijent = klijent;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if(odgovor.Signal == Signal.KlijentUspesnoDodat)
            {
                return true;
            }
            return false;
        }

      

        internal List<Klijent> VratiKlijente(string kriterijum, string text)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PretraziKlijente;
            zahtev.KriterijumPretrage = kriterijum;
            zahtev.TekstPretrage = text;
            formatter.Serialize(stream,zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);

            if (odgovor.Signal == Signal.UspesnaPretraga) return odgovor.ListaKlijenata;
            else return null;
        }
        internal List<Predmet> VratiPredmete(string kriterijum, string text)
        {

            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PretraziPredmete;
            zahtev.KriterijumPretrage = kriterijum;
            zahtev.TekstPretrage = text;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);

            if (odgovor.Signal == Signal.UspesnaPretraga) return odgovor.ListaPredmeta;
            else return null;
        }
        internal List<Predmet> VratiPredmete(string kriterijum, DateTime datum)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PretraziPredmete;
            zahtev.KriterijumPretrage = kriterijum;
            zahtev.Datum = datum;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);

            if (odgovor.Signal == Signal.UspesnaPretraga) return odgovor.ListaPredmeta;
            else return null;
        }
        internal List<Sastanak> VratiSastanke(string kriterijum, string text)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PretraziSastanke;
            zahtev.KriterijumPretrage = kriterijum;
            zahtev.TekstPretrage = text;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);

            if (odgovor.Signal == Signal.UspesnaPretraga) return odgovor.ListaSastanaka;
            else return null;
        }
        internal List<Sastanak> VratiSastanke(string kriterijum, DateTime datum)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PretraziSastanke;
            zahtev.KriterijumPretrage = kriterijum;
            zahtev.Datum = datum;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);

            if (odgovor.Signal == Signal.UspesnaPretraga) return odgovor.ListaSastanaka;
            else return null;
        }

    }
}
