using Domen;
using Kontroler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Zajednicki;

namespace Server
{
    public class ClientHandler
    {
        private Socket klijentskiSoket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();
        private Sekretar logovaniSekretar;
        private List<Sekretar> sekretari = Controller.Instance.VratiSekretare();
        
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
                            foreach(Sekretar sekretar in sekretari)
                            {
                                if(sekretar.KorisnickoIme == zahtev.Sekretar.KorisnickoIme && sekretar.Lozinka == zahtev.Sekretar.Lozinka)
                                {
                                    logovaniSekretar = sekretar;
                                    odgovor.Signal = Signal.UspesnoPrijavljen;
                                    odgovor.Sekretar = sekretar;
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
                    }
                }
            }
            catch
            {

            }
        }
    }
}