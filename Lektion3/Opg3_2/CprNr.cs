using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Objektorientering.Opg3_2
{
    internal class CprNr
    {
        public string BirthDate { get; set; }
        public string SequenceNumber { get; set; }

        public CprNr(String bDate, String sNumber)
        {
            BirthDate = bDate;
            SequenceNumber = sNumber;
        }

        public override int GetHashCode()
        {
            string cprNr = BirthDate + SequenceNumber; 
            return cprNr.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return this.GetHashCode()==obj.GetHashCode();
        }

        public override string ToString()
        {
            return BirthDate + "-" + SequenceNumber;
        }
    }
}
