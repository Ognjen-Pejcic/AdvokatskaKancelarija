using Domen;
using Kontroler;
using System.Collections.Generic;
using System.ComponentModel;
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
                    }
                }
            }
            catch
            {

            }
        }
    }
}