using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Angazovanje : DomenskiObjekat
    {
        public Predmet Predmet { get; set; }
        public Advokat Advokat { get; set; }

        [Browsable(false)]
        public string TableName => "Angazovanje";

        [Browsable(false)]
        public string InsertValues => $"{Predmet.PredmetID}, {Advokat.AdvokatID}, {Predmet.Klijent.KlijentID}";
        [Browsable(false)]

        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinFull => "angazovanje a join advokat aa on(a.advokatid = aa.advokatid) join premdet p on(p.predmetid = a.predmetid) ";
        [Browsable(false)]
        public string KriterijumPretrage => $"a.predmetid = {Predmet.PredmetID}";
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string Arhiviranje => throw new NotImplementedException();
        [Browsable(false)]
        public string UslovZaFiltriranje => throw new NotImplementedException();
        [Browsable(false)]
        public string PovratneVrednosti => throw new NotImplementedException();

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Predmet p = new Predmet
                {
                    PredmetID = reader.GetInt32(0),
                    Klijent = new Klijent
                    {
                        KlijentID = reader.GetInt32(1),
                        ImeKlijenta = reader.GetString(10),
                        Prezime = reader.GetString(11)
                    },
                    NazivPremdeta = reader.GetString(2),
                    DatumOtvaranja = reader.GetDateTime(3),
                    Arhiviran = reader.GetBoolean(4),
                    OpisPredmeta = reader.GetString(5),
                    Faza = reader.GetString(6),
                    VrstaPostupka = new VrstaPostupka
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
            throw new NotImplementedException();
        }

        public void PostaviVrednostiPretrage(string kriterijum, string text)
        {
            throw new NotImplementedException();
        }

        public void PostaviVrednostiPretrage(string kriterijum, string text, DateTime datum)
        {
            throw new NotImplementedException();
        }
    }
}
