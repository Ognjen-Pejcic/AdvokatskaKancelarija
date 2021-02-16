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
    public class Sastanak : DomenskiObjekat
    {
        public int SastanakID { get; set; }
        public DateTime DatumIVremeSastanka{get;set;}
        public Advokat Advokat { get; set; }
        public Klijent Klijent { get; set; }

        [Browsable(false)]
        public string TableName => "Sastanak";
        [Browsable(false)]
        public string InsertValues => $"'{DatumIVremeSastanka}', {Advokat.AdvokatID}, {Klijent.KlijentID}";
        [Browsable(false)]
        public string JoinCondition => throw new NotImplementedException();

        [Browsable(false)]
        public string JoinFull => $" s join advokat a on (s.advokatid = a.advokatid) join klijent k on (k.klijentid = s.klijentid)";
        [Browsable(false)]
        public string KriterijumPretrage => $" SastanakID = {SastanakID}";
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string Arhiviranje => throw new NotImplementedException();

        public string UslovZaFiltriranje => throw new NotImplementedException();

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Sastanak s = new Sastanak
                {
                    SastanakID = reader.GetInt32(0),
                    DatumIVremeSastanka = reader.GetDateTime(1),
                    Advokat = new Advokat
                    {
                        AdvokatID = reader.GetInt32(2)
                    },
                    Klijent = new Klijent
                    {
                        KlijentID =  reader.GetInt32(3)
                    }

                };
                list.Add(s);
            }
            return list;
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            Sastanak s = new Sastanak();
            while (reader.Read())
            {
                s.SastanakID = reader.GetInt32(0);
                s.DatumIVremeSastanka = reader.GetDateTime(1);
                s.Advokat = new Advokat
                {
                    AdvokatID = reader.GetInt32(2)
                };
                s.Klijent = new Klijent
                {
                    KlijentID = reader.GetInt32(3)
                };

                
                
            }
            return s;
        }

        public void PostaviVrednostiPretrage(string kriterijum, string text)
        {
            throw new NotImplementedException();
        }
    }
}
