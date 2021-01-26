using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    
    //sve ok valjda
    public class Advokat : DomenskiObjekat
    {
        public int AdvokatID{ get; set; }
        public string ImeAdvokata { get; set; }
        public string PrezimeAdovakta { get; set; }
        public string TelefonaAdvokata { get; set; }
        public string Specijalnost { get; set; }

        [Browsable(false)]
        public string TableName => "Advokat";

        public string InsertValues => throw new NotImplementedException();


        public string JoinCondition => throw new NotImplementedException();

        public string JoinFull => throw new NotImplementedException();

     

        public string KriterijumPretrage => $"AdvokatID = {AdvokatID}";


        public string UpdateValues => throw new NotImplementedException();

        public string Arhiviranje => throw new NotImplementedException();

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
    }
}
