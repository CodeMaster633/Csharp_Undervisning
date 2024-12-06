using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Sag
    {
        public int SagId { get; set; }
        public string Beskrivelse { get; set; }
        public string Overskrift { get; set; }
        public List<Tidsregistrering> Tidsregistreringer { get; set; }
        public int AfdelingId { get; set; }
        public Sag() { }
        public Sag(string beskrivelse, string overskrift, Afdeling afdeling)
        {
            Beskrivelse = beskrivelse;
            Overskrift = overskrift;
            AfdelingId = afdeling.AfdelingId;
            Tidsregistreringer = new List<Tidsregistrering>();
        }
        public Sag(string beskrivelse, string overskrift, Afdeling afdeling, int id)
        {
            Beskrivelse = beskrivelse;
            Overskrift = overskrift;
            AfdelingId = afdeling.AfdelingId;
            Tidsregistreringer = new List<Tidsregistrering>();
            SagId = id;
        }


    }
}
