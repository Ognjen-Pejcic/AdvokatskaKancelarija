using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DbBroker;
using Domen;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Advokat a = new Advokat
            //{
            //    AdvokatID=1,
            //    ImeAdvokata= "b",
            //    PrezimeAdovakta = "b",
            //    TelefonaAdvokata = "asdasda123",
            //    Specijalnost = "123",


            //};

            //Predmet p = new Predmet
            //{
            //    PredmetID = 2,
            //    Klijent = new Klijent
            //    {
            //        KlijentID = 1
            //    },

            //    DatumOtvaranja = DateTime.Parse("1/23/2021"),
            //    OpisPredmeta = ":Saa,sjdbaskdbhaskdhasd",
            //    Faza = "asdasd",
            //    VrstaPostupka = new VrstaPostupka
            //    {
            //        VrstaPostupkaID = 1
            //    },
            //    Arhiviran = false,
            //    NazivPremdeta = "jeste"

            //};

            Broker b = new Broker();
            b.OpenConnection();
            Predmet k = new Predmet();
            Console.WriteLine(k.DatumOtvaranja);
            //{
            //    DatumOtvaranja = DateTime.ParseExact("02/02/2021", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
            //    Klijent =  new Klijent(),
            //    VrstaPostupka = new VrstaPostupka()
            //};
            
            //List<DomenskiObjekat> o = b.VratiSveJoinWhere(k);
            //foreach (Predmet aa in o)
            //{
            //    Console.WriteLine(aa.NazivPremdeta);
            //}
            //Console.WriteLine(b.VratiMaxID(a));

            //Regex r = new Regex("^(0[1-9]|[1-2][0-9]|3[0-1])(0[1-9]|1[0-2])[0-9]{9}$");
            //if (r.IsMatch("333333333333333"))
            //{
            //    Console.WriteLine("jeste");
            //}
            //else {
            //    Console.WriteLine("nije");
            //}

        }
    }
}
