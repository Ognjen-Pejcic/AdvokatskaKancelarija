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

        [Browsable(false)]
        //$"(k.ImeKlijenta like '%'+'{Klijent.ImeKlijenta}'+'%' and p.nazivpredmeta like '%'+'{NazivPremdeta}'+'%' and p.opispredmeta like '%'+'{OpisPredmeta}'+'%' and p.faza like '%'+'{Faza}'+'%' and v.nazivvrstepostupka like '%'+'{VrstaPostupka.NazivVrste}'+'%') and 0 = (case when YEAR('{DatumOtvaranja}')=1 then 0 else datediff(day, p.datumotvaranja, '{DatumOtvaranja}')end) ";
        public string UslovZaFiltriranje => $"(concat(a.imeadvokata, concat(' ', a.prezimeadvokata)) like '%'+'{Advokat.ImeAdvokata}'+'%' and concat(k.imeklijenta, concat(' ', k.prezimeklijenta)) like '%'+'{Klijent.ImeKlijenta}'+'%') and 0 = (case when YEAR('{DatumIVremeSastanka}')=1 then 0 else datediff(day, s.datumvreme, '{DatumIVremeSastanka}')end) ";
        [Browsable(false)]
        public string PovratneVrednosti => " s.sastanakid, s.datumvreme, concat(a.imeadvokata, concat(' ', a.prezimeadvokata)) as 'Advokat', concat(k.imeklijenta, concat(' ', k.prezimeklijenta)) as 'Klijnet'  ";

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
                        ImeAdvokata = reader.GetString(2)
                    },
                    Klijent = new Klijent
                    {
                        ImeKlijenta =  reader.GetString(3)
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
                    ImeAdvokata = reader.GetString(2)

                };
                s.Klijent = new Klijent
                {
                    ImeKlijenta = reader.GetString(3)
                };

                
                
            }
            return s;
        }

    

        public void PostaviVrednostiPretrage(string kriterijum, string text, DateTime datum)
        {
            //Klijentu Advokatu Datumu
            this.Klijent = new Klijent();
            this.Advokat = new Advokat();
            if (kriterijum == "Klijentu")
            {
                this.Klijent.ImeKlijenta = text;
            }

            else if (kriterijum == "Advokatu")
            {
                this.Advokat.ImeAdvokata = text;
            }
            else this.DatumIVremeSastanka = datum;
        }
    }
}
