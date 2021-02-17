using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen

{
    [Serializable]
    public class Sekretar :DomenskiObjekat
    {
        public int SekretarID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public string TableName => "Sekretar";

        public string InsertValues => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string JoinFull => throw new NotImplementedException();

        public string KriterijumPretrage => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string Arhiviranje => throw new NotImplementedException();

        public string UslovZaFiltriranje => throw new NotImplementedException();

        public string PovratneVrednosti => " * ";

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Sekretar s = new Sekretar
                {
                    SekretarID = reader.GetInt32(0),
                    KorisnickoIme = reader.GetString(1),
                    Lozinka = reader.GetString(2)

                };
                list.Add(s);
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
