using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Objektorientering.Opg3_2
{
    internal class Mekaniker : Medarbejder
    {
        public double TimeLoen { get; set; }
        public int SvendepoeveAar {  get; set; }

        public Mekaniker(string navn, string adresse, CprNr cprNr, string medarbejderNr,
            double timeloen, int svendepoeve) : base(navn, adresse, cprNr,medarbejderNr) {
            TimeLoen = timeloen;
            SvendepoeveAar = svendepoeve;
        }

        public override double BeregnUgeLøn()
        {
            return TimeLoen * TimerPrUge;
        }
    }
}
