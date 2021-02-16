using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public VrstaPostupka VrstaPostupka { get; set; }

        public string TableName => "Predmet";

        public string InsertValues => $"{Klijent.KlijentID}, '{NazivPremdeta}', '{DatumOtvaranja}', '{Arhiviran}', '{OpisPredmeta}', '{Faza}', {VrstaPostupka.VrstaPostupkaID}";

        public string JoinCondition => throw new NotImplementedException();

        public string JoinFull => "p join klijent k on(klijent.klijentid = p.klijentid)";

        public string KriterijumPretrage => $"predmetid = {PredmetID}";

        public string UpdateValues => $"klijentid = {Klijent.KlijentID}, nazivpredmeta ='{NazivPremdeta}', datumotvaranja = '{DatumOtvaranja}', arhiviran = '{Arhiviran}', opispredmeta = '{OpisPredmeta}', faza ='{Faza}', vrstapostupkaid = {VrstaPostupka.VrstaPostupkaID}";


        public string Arhiviranje => "arhiviran = 'true'";

        public string UslovZaFiltriranje => throw new NotImplementedException();

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {

            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Predmet p = new Predmet
                {
                    PredmetID = reader.GetInt32(0),
                    Klijent = new Klijent { 
                    KlijentID = reader.GetInt32(1)
                    },NazivPremdeta = reader.GetString(2),
                    DatumOtvaranja = reader.GetDateTime(3),
                    Arhiviran = reader.GetBoolean(4),
                    OpisPredmeta = reader.GetString(5),
                    Faza = reader.GetString(6),
                    VrstaPostupka =  new VrstaPostupka
                    {
                        VrstaPostupkaID = reader.GetInt32(7)
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
                        KlijentID = reader.GetInt32(1)
                    };
                p.NazivPremdeta = reader.GetString(2);
                p.DatumOtvaranja = reader.GetDateTime(3);
                p.Arhiviran = reader.GetBoolean(4);
                p.OpisPredmeta = reader.GetString(5);
                p.Faza = reader.GetString(6);
                p.VrstaPostupka = new VrstaPostupka
                {
                    VrstaPostupkaID = reader.GetInt32(7)
                };

               
              

            }
            return p;
        }

        public void PostaviVrednostiPretrage(string kriterijum, string text)
        {
            throw new NotImplementedException();
        }
    }
}
