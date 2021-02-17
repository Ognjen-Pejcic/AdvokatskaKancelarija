using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface DomenskiObjekat
    {
        string TableName { get; }
        string InsertValues { get; }
     //   string PovratneVrednosti { get; }
        string JoinCondition { get; }
        string JoinFull { get; }
       
        string KriterijumPretrage { get; }

        string UpdateValues { get; }
        string Arhiviranje { get; }
        string UslovZaFiltriranje { get;  }
        void PostaviVrednostiPretrage(string kriterijum, string text, DateTime datum);
        List<DomenskiObjekat> GetEntities(SqlDataReader reader);
        DomenskiObjekat GetEntity(SqlDataReader reader);
    }
}
