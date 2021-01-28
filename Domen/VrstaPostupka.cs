using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
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
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                VrstaPostupka vrsta = new VrstaPostupka
                {
                    VrstaPostupkaID = reader.GetInt32(0),
                    NazivVrste = reader.GetString(1)
                    

                };
                list.Add(vrsta);
            }
            return list;
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return NazivVrste;
        }
    }
}