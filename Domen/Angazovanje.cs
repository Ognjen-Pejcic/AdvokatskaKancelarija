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
        public string JoinFull => " a join advokat aa on(a.advokatid = aa.advokatid) join predmet p on(p.predmetid = a.predmetid) ";
        [Browsable(false)]
        public string KriterijumPretrage => $"a.predmetid = {Predmet.PredmetID}";
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string Arhiviranje => throw new NotImplementedException();
        [Browsable(false)]
        public string UslovZaFiltriranje => $"a.predmetid = {Predmet.PredmetID}";
        [Browsable(false)]
        public string PovratneVrednosti => "*";

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Angazovanje a = new Angazovanje
                {
                    Predmet = new Predmet
                    {
                        PredmetID = reader.GetInt32(0),

                        NazivPremdeta = reader.GetString(10),
                        DatumOtvaranja = reader.GetDateTime(11),
                    },
                    Advokat = new Advokat
                    {
                        AdvokatID = reader.GetInt32(1),
                        ImeAdvokata = reader.GetString(4),
                        PrezimeAdovakta = reader.GetString(5)
                    }
                };
                
                    

                
                list.Add(a);
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
        public override string ToString()
        {
            return Advokat.ImeAdvokata + Advokat.PrezimeAdovakta;
        }
    }
}
