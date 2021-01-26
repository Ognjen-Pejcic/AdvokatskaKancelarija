using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    public class VrstaPostupka : DomenskiObjekat
    {
        public int VrstaPostupkaID { get; set; }
        public string NazivVrste { get; set; }

        public string TableName => "VrstaPostupka";

        public string InsertValues => throw new System.NotImplementedException();

        public string JoinCondition => throw new System.NotImplementedException();

        public string JoinFull => throw new System.NotImplementedException();

        public string KriterijumPretrage => $"vrstapostupkaid = {VrstaPostupkaID}";

        public string UpdateValues => throw new System.NotImplementedException();

        public string Arhiviranje => throw new System.NotImplementedException();

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            throw new System.NotImplementedException();
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            throw new System.NotImplementedException();
        }
    }
}