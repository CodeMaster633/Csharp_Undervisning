using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Objektorientering.Opg3_2
{
    internal class Vaerkfoerer : Mekaniker
    {
        public int UdnaevnelsesAar { get; set; }
        public double TillægUge { get; set; }

        public Vaerkfoerer(string navn, string adresse, CprNr cprNr, string medarbejderNr, double timeloen, int svendepoeve,
            int udnaevnelsesAar, double tillægUge) : base(navn, adresse, cprNr,medarbejderNr, timeloen, svendepoeve)

        {
            UdnaevnelsesAar = udnaevnelsesAar;
            TillægUge= tillægUge;
        }
        public override double BeregnUgeLøn()
        {
            return TimeLoen * TimerPrUge + TillægUge;
        }
    }
}
