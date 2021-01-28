using System;
using System.Collections.Generic;
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

        public string TableName => "Angazovanje";

        public string InsertValues => $"{Predmet.PredmetID}, {Advokat.AdvokatID}, {Predmet.Klijent.KlijentID}";

        public string JoinCondition => throw new NotImplementedException();

        public string JoinFull => "a join advokat aa on(a.advokatid = aa.advokatid) join premdet p on(p.predmetid = a.predmetid) ";

        public string KriterijumPretrage => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string Arhiviranje => throw new NotImplementedException();

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
       
    }
}
