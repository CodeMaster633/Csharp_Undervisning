namespace L03_Objektorientering.Opg3_2
{
    internal class Synsmand : Mekaniker
    {
        public int AntalSyn { get; set; }

        public Synsmand(string navn, string adresse, CprNr cprNr, string medarbejderNr, double timeloen, int svendepoeve,
            int antalSyn) : base(navn, adresse, cprNr, medarbejderNr, timeloen, svendepoeve)

        {
            AntalSyn = antalSyn;
        }

        public override double BeregnUgeLøn()
        {
            return AntalSyn*290;
        }
    }
}

