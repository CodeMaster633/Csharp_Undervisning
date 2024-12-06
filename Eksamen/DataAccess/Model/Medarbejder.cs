using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Medarbejder
    {
        public string CprNummer { get; set; }
        public string Navn { get; set; }
        public int MedarbejderId { get; set; }
        public Afdeling Afdeling { get; set; }
        public int AfdelingId { get; set; }
        public List<Tidsregistrering> Tidsregistreringer { get; set; }

        public Medarbejder() { }
        public Medarbejder(string cprNummer, string navn, int medarbejderId, Afdeling afdeling)
        {
            CprNummer = cprNummer;
            Navn = navn;
            MedarbejderId = medarbejderId;
            Afdeling = afdeling;
            Tidsregistreringer = new List<Tidsregistrering>();

        }
    }
}
