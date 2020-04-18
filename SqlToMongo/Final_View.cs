using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace SqlToMongo
{
    class Final_View
    {
        public ObjectId Id { get; set; }
        public Nullable<DateTime> DatoMaerke { get; set; }
        public string Navn { get; set; }
        public int ProduktId { get; set; }
        public Nullable<double> RaaResultat { get; set; }
        public string Kode { get; set; }
        public string StofNavn { get; set; }
        public string Expr1 { get; set; }

        public Final_View(DateTime datoMaerke, string navn, int produktid, double raaResultat, string kode, string stofNavn, string expr1 )
        {
            DatoMaerke = datoMaerke;
            Navn = navn;
            ProduktId = produktid;
            RaaResultat = raaResultat;
            Kode = kode;
            StofNavn = stofNavn;
            Expr1 = expr1;
        }

        Final_View()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
