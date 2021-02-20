using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
        }

        internal bool Login(string korisnickoime, string lozinka)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
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
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.IzmeniKlijenta;
                zahtev.Klijent = klijent;
                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.KlijentUspesnoIzmenjen)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        internal Predmet VratiPremdet(int predmetID)
        {
            try { 
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiPredmet;
            zahtev.ID = predmetID;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.Predmet;
        }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
}



        internal List<VrstaPostupka> PrikaziVrste()
        {
            try { 
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiVrste;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.ListaVrsta;
        }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        internal bool ArhivirajPredmet(Predmet predmet)
        {
            try { 
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
}

        internal Sastanak VratiSastanak(int sastanakID)
        {
            try{
                Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiSastanak;
            zahtev.ID = sastanakID;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.Sastanak;
        }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
}

        internal Klijent PrikaziKlijenta(int id)
        {
            try{
                Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiKlijenta;
            zahtev.ID = id;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.Klijent;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


        internal List<Advokat> PrikaziAdvokate()
        {
            try
            {

           
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiAdvokate;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.ListaAdvokata;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        internal bool DodajPredmet(Predmet predmet, List<Angazovanje> angazovanja)
        {
            try {
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        internal bool Sacuvaj(BindingList<Sastanak> sastanci)
        {
            try{
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        internal List<Klijent> PrikaziKlijente()
        {
            try { 
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiKlijente;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.ListaKlijenata;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        internal bool DodajKlijenta(Klijent klijent)
        {
            try{
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

      

        internal List<Klijent> VratiKlijente(string kriterijum, string text)
        {
            try { 
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PretraziKlijente;
            zahtev.KriterijumPretrage = kriterijum;
            zahtev.TekstPretrage = text;
            formatter.Serialize(stream,zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);

            if (odgovor.Signal == Signal.UspesnaPretraga) return odgovor.ListaKlijenata;
            else return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        internal List<Predmet> VratiPredmete(string kriterijum, string text)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        internal List<Predmet> VratiPredmete(string kriterijum, DateTime datum)
        {
            try {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PretraziPredmete;
            zahtev.KriterijumPretrage = kriterijum;
            zahtev.Datum = datum;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);

            if (odgovor.Signal == Signal.UspesnaPretraga) return odgovor.ListaPredmeta;
            else return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        internal List<Sastanak> VratiSastanke(string kriterijum, string text)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
}
        internal List<Sastanak> VratiSastanke(string kriterijum, DateTime datum)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

    }
}
