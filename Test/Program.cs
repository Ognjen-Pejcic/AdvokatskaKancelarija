using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbBroker;
using Domen;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Advokat a = new Advokat
            {
                AdvokatID=1,
                ImeAdvokata= "b",
                PrezimeAdovakta = "b",
                TelefonaAdvokata = "asdasda123",
                Specijalnost = "123",


            };

            Predmet p = new Predmet
            {
                PredmetID = 2,
                Klijent = new Klijent
                {
                    KlijentID = 1
                },

                DatumOtvaranja = DateTime.Parse("1/23/2021"),
                OpisPredmeta = ":Saa,sjdbaskdbhaskdhasd",
                Faza = "asdasd",
                VrstaPostupka = new VrstaPostupka
                {
                    VrstaPostupkaID = 1
                },
                Arhiviran = false,
                NazivPremdeta = "jeste"

            };
           
            Broker b = new Broker();
            //b.OpenConnection();
            //if (b.Sacuvaj(p) == 1)
            //    Console.WriteLine("232ebwh");
            //b.CloseConnection();
            b.OpenConnection();
            //List<DomenskiObjekat> o = b.Pronadji(p);
            //foreach (Predmet aa in o)
            //{
            //    Console.WriteLine(aa.NazivPremdeta);
            //}
            try
            {
                b.Arhiviraj(p);
                Console.WriteLine("232ebwh");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
