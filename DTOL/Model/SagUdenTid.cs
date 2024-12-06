using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOL.Model
{
    public class SagUdenTid
    {
        public int SagId { get; set; }
        public string Beskrivelse { get; set; }
        public string Overskrift { get; set; }
        public int AfdelingId { get; set; }
        public Afdeling Afdeling { get; set; }

        public SagUdenTid() { }

        public SagUdenTid(string beskrivelse, string overskrift, Afdeling afdeling)
        {
            Beskrivelse = beskrivelse;
            Overskrift = overskrift;
            AfdelingId = afdeling.AfdelingId;
            Afdeling = afdeling;
        }

        public SagUdenTid(string beskrivelse, string overskrift, Afdeling afdeling, int id)
        {
            Beskrivelse = beskrivelse;
            Overskrift = overskrift;
            AfdelingId = afdeling.AfdelingId;
            Afdeling = afdeling;
            SagId = id;
        }
    }

}
