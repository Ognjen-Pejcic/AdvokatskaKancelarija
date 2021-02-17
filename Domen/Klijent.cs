using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [Browsable(false)]
        public string TableName => "Klijent";
        [Browsable(false)]
        public string InsertValues => $"'{JMBGKlijenta}', '{ImeKlijenta}', '{Prezime}', '{TelefonKlijenta}', '{AdresaKlijenta}'";

        [Browsable(false)]
        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinFull => throw new NotImplementedException();


        [Browsable(false)]
        public string KriterijumPretrage => $"klijentid = {KlijentID}";
        [Browsable(false)]
        public string UpdateValues => $"Jmbgklijenta = '{JMBGKlijenta}', imeklijenta = '{ImeKlijenta}', prezimeklijenta = '{Prezime}', telefonklijenta = '{TelefonKlijenta}', adresaklijenta = '{AdresaKlijenta}'";
        [Browsable(false)]
        public string Arhiviranje => throw new NotImplementedException();
        [Browsable(false)]
        public string UslovZaFiltriranje => $"JMBGKlijenta like '%'+'{JMBGKlijenta}'+'%' and imeklijenta like '%'+'{ImeKlijenta}'+'%' and prezimeklijenta like '%'+'{Prezime}'+'%' and adresaklijenta like '%'+'{AdresaKlijenta}'+'%' and telefonklijenta like '%'+'{TelefonKlijenta}'+'%'";
        [Browsable(false)]
        public string PovratneVrednosti => " * ";

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

       
        public void PostaviVrednostiPretrage(string kriterijum, string text)
        {
            //JMBG-u Imenu Prezimenu Adresi Telefonu
            if (kriterijum == "JMBG-u") JMBGKlijenta = text;
            else if (kriterijum == "Imenu") ImeKlijenta = text;
            else if (kriterijum == "Prezimenu") Prezime = text;
            else if (kriterijum == "Adresi") AdresaKlijenta = text;
            else if (kriterijum == "Telefonu") TelefonKlijenta = text;
            

            
        }

        public void PostaviVrednostiPretrage(string kriterijum, string text, DateTime datum)
        {
            throw new NotImplementedException();
        }
    }
}
