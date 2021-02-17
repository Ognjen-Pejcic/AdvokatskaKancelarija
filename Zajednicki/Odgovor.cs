using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki
{
    [Serializable]
    public class Odgovor
    {
        public Signal Signal { get; set; }
        public Sekretar Sekretar { get; set; }
        public List<Advokat> ListaAdvokata { get; set; }
        public List<Klijent> ListaKlijenata { get; set; }
        public List<VrstaPostupka> ListaVrsta { get; set; }
        public int ID { get; set; }
        public Klijent Klijent { get; set; }
        public Sastanak Sastanak{ get; set; }
        public Predmet Predmet{ get; set; }
        public List<Predmet> ListaPredmeta { get; set; }
        public List<Sastanak> ListaSastanaka { get; set; }
    }

    public enum Signal
    {
        UspesnoPrijavljen,
        KlijentUspesnoDodat,
        SastanciUspesnoZakazani,
        PredmetUspesnoDodat,
        NeuspesnaPretraga,
        UspesnaPretraga,
        KlijentUspesnoIzmenjen,
        PredmetUspesnoArhiviran
    }
}
