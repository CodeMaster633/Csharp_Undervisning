using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Objektorientering.Opg3_2
{
    internal class Firma : IHarAdresse
    {
        public string Navn { get; set; }
        public string CvrNr { get; set; }
        public string Adresse { get; set; }

        public Firma(string navn, string cvrNr, string adresse) {
            Navn = navn;
            CvrNr = cvrNr;
            Adresse = adresse;
        }
    }
}
