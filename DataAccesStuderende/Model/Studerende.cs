using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Studerende
    {
        public Studerende() { }
        public Studerende(string navn, DateTime studiestart, int alder, Enum studietype)
        {
            Navn = navn;
            Studiestart = studiestart;
            Alder = alder;
            Studietype = studietype;
        }
        
        public string Navn {  get; set; }
        public DateTime Studiestart { get; set; }
        public int Alder { get; set; }
        public Enum Studietype { get; set; }

    }

    public enum Studietype
    {
        Master,
        Bachelor,
        Enkeltfag,
        Videreuddannelse
    }
}
