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
    public class Advokat : DomenskiObjekat
    {
        [Browsable(false)]

        public int AdvokatID{ get; set; }
        public string ImeAdvokata { get; set; }
        public string PrezimeAdovakta { get; set; }
        public string TelefonaAdvokata { get; set; }
        public string Specijalnost { get; set; }

        [Browsable(false)]
        public string TableName => "Advokat";
        [Browsable(false)]
        public string InsertValues => throw new NotImplementedException();

        [Browsable(false)]

        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]

        public string JoinFull => throw new NotImplementedException();

        [Browsable(false)]


        public string KriterijumPretrage => $"AdvokatID = {AdvokatID}";

        [Browsable(false)]

        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
      
        public string Arhiviranje => throw new NotImplementedException();
        [Browsable(false)]
        public string UslovZaFiltriranje => throw new NotImplementedException();
        [Browsable(false)]
        public string PovratneVrednosti => " * ";

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Advokat advokat = new Advokat
                {
                    AdvokatID = reader.GetInt32(0),
                    ImeAdvokata = reader.GetString(1),
                    PrezimeAdovakta= reader.GetString(2),
                    TelefonaAdvokata = reader.GetString(3),
                    Specijalnost = reader.GetString(4)
                };
                list.Add(advokat);
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
            return ImeAdvokata + " " + PrezimeAdovakta;
        }
    }
}
