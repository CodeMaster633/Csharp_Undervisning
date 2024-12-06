using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOL.Model
{
    public class Sag
    {
        public int SagId { get; set; }
        public string Beskrivelse { get; set; }
        public string Overskrift { get; set; }
        public List<Tidsregistrering> Tidsregistreringer { get; set; }
        public int AfdelingId { get; set; }
        public Afdeling Afdeling { get; set; }

        public Sag() { }

        public Sag(string beskrivelse, string overskrift, Afdeling afdeling)
        {
            Beskrivelse = beskrivelse;
            Overskrift = overskrift;
            AfdelingId = afdeling.AfdelingId;
            Afdeling = afdeling;
            Tidsregistreringer = new List<Tidsregistrering>();
        }

        public Sag(string beskrivelse, string overskrift, int sagId, int afdelingId)
        {
            Beskrivelse = beskrivelse;
            Overskrift = overskrift;
            AfdelingId = afdelingId;
            Tidsregistreringer = new List<Tidsregistrering>();
            SagId = sagId;
        }
    }

}
