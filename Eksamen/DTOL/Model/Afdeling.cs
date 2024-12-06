using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOL.Model
{
    public class Afdeling
    {
        public int AfdelingId { get; set; }
        public string Navn { get; set; }
        public List<Medarbejder> Medarbejdere { get; set; }
        public List<Sag> Sager { get; set; }

        public Afdeling() { }
        public Afdeling(string navn, int id)
        {
            Navn = navn;
            AfdelingId = id;
        }
        public Afdeling(string navn)
        {
            Navn = navn;

        }

    }
}
