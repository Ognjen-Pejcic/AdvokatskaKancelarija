using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Predmet : DomenskiObjekat
    {
        public int PredmetID { get; set; }
        public Klijent Klijent { get; set; }
        public string NazivPremdeta { get; set; }
        public DateTime DatumOtvaranja { get; set; }
        public bool Arhiviran { get; set; }

        public string OpisPredmeta { get; set; }

        public string Faza { get; set; }
        public List<Angazovanje> Angazovanja { get; set; }
        public VrstaPostupka VrstaPostupka { get; set; }

        [Browsable(false)]
        public string TableName => "Predmet";

        [Browsable(false)]
        public string InsertValues => $"{Klijent.KlijentID}, '{NazivPremdeta}', '{DatumOtvaranja}', '{Arhiviran}', '{OpisPredmeta}', '{Faza}', {VrstaPostupka.VrstaPostupkaID}";

        [Browsable(false)]
        public string JoinCondition => $"p.predmetid = {PredmetID}";

        [Browsable(false)]
        public string JoinFull => "p join klijent k on(k.klijentid = p.klijentid) join vrstapostupka v on (v.vrstapostupkaID = p.vrstaPostupkaID) ";

        [Browsable(false)]
        public string KriterijumPretrage => $"predmetid = {PredmetID}";
        [Browsable(false)]
        public string UpdateValues => $" nazivpredmeta ='{NazivPremdeta}', datumotvaranja = '{DatumOtvaranja}', opispredmeta = '{OpisPredmeta}', faza ='{Faza}', vrstapostupkaid = {VrstaPostupka.VrstaPostupkaID}";

        [Browsable(false)]
        public string Arhiviranje => "arhiviran = 'true'";

       
        [Browsable(false)]
        //CONVERT(VARCHAR(10),p.DatumOtvaranja,120) = '{DatumOtvaranja.Date}' "
        public string UslovZaFiltriranje => $"(k.ImeKlijenta like '%'+'{Klijent.ImeKlijenta}'+'%' and p.nazivpredmeta like '%'+'{NazivPremdeta}'+'%' and p.opispredmeta like '%'+'{OpisPredmeta}'+'%' and p.faza like '%'+'{Faza}'+'%' and v.nazivvrstepostupka like '%'+'{VrstaPostupka.NazivVrste}'+'%') and 0 = (case when YEAR('{DatumOtvaranja}')=1 then 0 else datediff(day, p.datumotvaranja, '{DatumOtvaranja}')end) ";
        [Browsable(false)]
        public string PovratneVrednosti => " * ";

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {

            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Predmet p = new Predmet
                {
                    PredmetID = reader.GetInt32(0),
                    Klijent = new Klijent { 
                        KlijentID = reader.GetInt32(1),
                        ImeKlijenta = reader.GetString(10),
                        Prezime = reader.GetString(11)
                    },
                    NazivPremdeta = reader.GetString(2),
                    DatumOtvaranja = reader.GetDateTime(3),
                    Arhiviran = reader.GetBoolean(4),
                    OpisPredmeta = reader.GetString(5),
                    Faza = reader.GetString(6),
                    VrstaPostupka =  new VrstaPostupka
                    {
                        VrstaPostupkaID = reader.GetInt32(7),
                        NazivVrste = reader.GetString(15)
                    }

                };
                list.Add(p);
            }
            return list;
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            Predmet p = new Predmet();
            while (reader.Read())
            {

                p.PredmetID = reader.GetInt32(0);
                    p.Klijent = new Klijent
                    {
                        KlijentID = reader.GetInt32(1),
                        ImeKlijenta = reader.GetString(10),
                        Prezime = reader.GetString(11)
                    };
                p.NazivPremdeta = reader.GetString(2);
                p.DatumOtvaranja = reader.GetDateTime(3);
                p.Arhiviran = reader.GetBoolean(4);
                p.OpisPredmeta = reader.GetString(5);
                p.Faza = reader.GetString(6);
                p.VrstaPostupka = new VrstaPostupka
                {
                    VrstaPostupkaID = reader.GetInt32(7),
                    NazivVrste = reader.GetString(15)
                };

               
              

            }
            return p;
        }

        public void PostaviVrednostiPretrage(string kriterijum, string text, DateTime datum)
        {
            //Klijentu Nazivu premdeta Datumu otvaranja  Opisu predmeta Fazi Vrsti postupka
            this.Klijent = new Klijent();
            this.VrstaPostupka = new VrstaPostupka();
            if (kriterijum == "Klijentu")
            {
                this.Klijent.ImeKlijenta = text;
            }

            else if (kriterijum == "Nazivu premdeta") NazivPremdeta = text;
            else if (kriterijum == "Datumu otvaranja") DatumOtvaranja = datum;
            else if (kriterijum == "Opisu predmeta") OpisPredmeta = text;
            else if (kriterijum == "Fazi") Faza = text;
            else if (kriterijum == "Vrsti postupka")
            {
                this.VrstaPostupka.NazivVrste = text;

            }
        }
    }
}
