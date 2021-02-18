using Domen;
using Kontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Zajednicki;

namespace Server
{
    public class ClientHandler
    {
        public Socket klijentskiSoket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();
        private static List<Sekretar> sekretari = Controller.Instance.VratiSekretare();
        public  static List<Sekretar> logovaniSekretari = new List<Sekretar>();
        public ClientHandler(Socket KlijentskiSoket)
        {
            this.klijentskiSoket = KlijentskiSoket;
            this.stream = new NetworkStream(KlijentskiSoket);
        }
        internal void ObradiZahteve()
        {
            try
            {
                while (true)
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
                    Odgovor odgovor = new Odgovor();
                    switch (zahtev.Operacija)
                    {
                        case Operacija.Login:


                            bool provera = true;
                                foreach (Sekretar sekretar in sekretari)
                                {
                                foreach (Sekretar s in logovaniSekretari)
                                {
                                    if(s.KorisnickoIme== sekretar.KorisnickoIme && s.Lozinka == sekretar.Lozinka)
                                    {
                                        odgovor.Sekretar = null;
                                        odgovor.Signal = Signal.NeuspesnaPretraga;
                                        provera = false;
                                        break;

                                    }

                                    
                                }
                                if (sekretar.KorisnickoIme == zahtev.Sekretar.KorisnickoIme && sekretar.Lozinka == zahtev.Sekretar.Lozinka && provera)
                                {

                                    odgovor.Signal = Signal.UspesnoPrijavljen;
                                    odgovor.Sekretar = sekretar;
                                    logovaniSekretari.Add(sekretar);
                                    break;
                                }
                            }
                            formatter.Serialize(stream, odgovor);

                            break;
                        case Operacija.DodajKlijenta:
                            if (Controller.Instance.SacuvajKlijenta(zahtev.Klijent))
                            {
                                odgovor.Signal = Signal.KlijentUspesnoDodat;
                            }
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.VratiAdvokate:
                            odgovor.ListaAdvokata = Controller.Instance.VratiListuAdvokata();
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.VratiKlijente:
                            odgovor.ListaKlijenata = Controller.Instance.VratiListuKlijenata();
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.ZakaziSastanke:
                            if (Controller.Instance.ZakaziSastanke(zahtev.Sastanci.ToList()))
                            {
                                odgovor.Signal = Signal.SastanciUspesnoZakazani;
                            }
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.VratiVrste:
                            odgovor.ListaVrsta = Controller.Instance.VratiListuVrsta();
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.VratiID:
                            odgovor.ID = Controller.Instance.VratiID(zahtev.DomenskiObjekat);
                            formatter.Serialize(stream,odgovor);
                            break;
                        case Operacija.DodajPredmet:
                            if(Controller.Instance.SacuvajPredmet(zahtev.Predmet, zahtev.Angazovanja))
                            {
                                odgovor.Signal = Signal.PredmetUspesnoDodat;
                            }
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.PretraziKlijente:
                            odgovor.ListaKlijenata = Controller.Instance.NadjiKlijente(zahtev.KriterijumPretrage, zahtev.TekstPretrage, new Klijent());
                            if (odgovor.ListaKlijenata.Count == 0) odgovor.Signal = Signal.NeuspesnaPretraga;
                            else odgovor.Signal = Signal.UspesnaPretraga;
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.VratiKlijenta:
                            odgovor.Klijent = Controller.Instance.UcitajKlijenta(new Klijent{ KlijentID = zahtev.ID });
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.IzmeniKlijenta:
                            if (Controller.Instance.IzmeniKlijena(zahtev.Klijent))
                            {
                                odgovor.Signal = Signal.KlijentUspesnoIzmenjen;
                            }
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.PretraziPredmete:
                            odgovor.ListaPredmeta = Controller.Instance.NadjiPredmete(zahtev.KriterijumPretrage, zahtev.TekstPretrage,zahtev.Datum, new Predmet());
                            if (odgovor.ListaPredmeta.Count == 0) odgovor.Signal = Signal.NeuspesnaPretraga;
                            else odgovor.Signal = Signal.UspesnaPretraga;
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.ArhivirajPredmet:
                            if (Controller.Instance.ArhivirajPredmet(zahtev.Predmet))
                            {
                                odgovor.Signal = Signal.PredmetUspesnoArhiviran;
                            }
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.PretraziSastanke:
                            odgovor.ListaSastanaka = Controller.Instance.NadjiSastanke(zahtev.KriterijumPretrage, zahtev.TekstPretrage, zahtev.Datum, new Sastanak());
                            if (odgovor.ListaSastanaka.Count == 0) odgovor.Signal = Signal.NeuspesnaPretraga;
                            else odgovor.Signal = Signal.UspesnaPretraga;
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.IzmeniPredmet:
                            if (Controller.Instance.IzmeniPredmet(zahtev.Predmet))
                            {
                                odgovor.Signal = Signal.PredmetUspesnoDodat;
                            }
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.VratiPredmet:
                            odgovor.Predmet = Controller.Instance.UcitajPredmet(new Predmet { PredmetID = zahtev.ID});
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.VratiSastanak:
                            odgovor.Sastanak = Controller.Instance.UcitajSastanak(new Sastanak { SastanakID = zahtev.ID });
                            formatter.Serialize(stream, odgovor);
                            break;
                        case Operacija.IzlogujSe:
                            foreach(Sekretar s in logovaniSekretari)
                            {
                                if(s.KorisnickoIme == zahtev.Sekretar.KorisnickoIme)
                                {
                                    logovaniSekretari.Remove(s);
                                    break;
                                }
                            }
                            break;
                        case Operacija.Prekini:
                            throw new SocketException();
                            break;
                    }
                }
            }
 
            catch(Exception e)
            {
               
                
            }
        }
    }
}