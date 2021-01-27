﻿using Domen;
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

        internal List<Advokat> PrikaziAdvokate()
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiAdvokate;
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            return odgovor.ListaAdvokata;
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

        internal bool Login(string korisnickoime, string lozinka)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.Login;
            zahtev.Sekretar = new Sekretar
            {
                KorisnickoIme = korisnickoime,
                Lozinka = lozinka
            };
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if(odgovor.Signal == Signal.UspesnoPrijavljen)
            {
                return true;
            }
            return false;
        }

        internal bool Connect()
        {
            try
            {
                if(klijentskiSoket ==null || !klijentskiSoket.Connected)
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

    }
}
