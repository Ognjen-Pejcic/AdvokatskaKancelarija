using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    //SVE OK
    [Serializable]
    public class Klijent : DomenskiObjekat
    {
        public int KlijentID { get; set; }
        public string JMBGKlijenta { get; set; }
        public string ImeKlijenta { get; set; }

        public string Prezime { get; set; }
        public string TelefonKlijenta { get; set; }
        public string AdresaKlijenta { get; set; }

        public string TableName => "Klijent";

        public string InsertValues => $"'{JMBGKlijenta}', '{ImeKlijenta}', '{Prezime}', '{TelefonKlijenta}', '{AdresaKlijenta}'";


        public string JoinCondition => throw new NotImplementedException();

        public string JoinFull => throw new NotImplementedException();

        public string KriterijumPretrage => $"klijentid = {KlijentID}";

        public string UpdateValues => $"Jmbgklijenta = '{JMBGKlijenta}', imeklijenta = '{ImeKlijenta}', prezimeklijenta = '{Prezime}', telefonklijenta = '{TelefonKlijenta}', adresaklijenta = '{AdresaKlijenta}'";

        public string Arhiviranje => throw new NotImplementedException();

        public List<DomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<DomenskiObjekat> list = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Klijent klijent = new Klijent
                {
                    KlijentID = reader.GetInt32(0),
                    JMBGKlijenta = reader.GetString(1),
                    ImeKlijenta = reader.GetString(2),
                    Prezime = reader.GetString(3),
                    TelefonKlijenta = reader.GetString(4),
                    AdresaKlijenta = reader.GetString(5),

                };
                list.Add(klijent);
            }
            return list;
        }

        public DomenskiObjekat GetEntity(SqlDataReader reader)
        {
            Klijent klijent = new Klijent();
            while (reader.Read())
            {

                klijent.KlijentID = reader.GetInt32(0);
                klijent.JMBGKlijenta = reader.GetString(1);
                klijent.ImeKlijenta = reader.GetString(2);
                klijent.Prezime = reader.GetString(3);
                klijent.TelefonKlijenta = reader.GetString(4);
                klijent.AdresaKlijenta = reader.GetString(5);

            }
            reader.Close();
            return klijent;
        }
        public override string ToString()
        {
            return ImeKlijenta + " " +Prezime;
        }
    }
}
