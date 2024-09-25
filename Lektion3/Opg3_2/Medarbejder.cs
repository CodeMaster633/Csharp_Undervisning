namespace L03_Objektorientering.Opg3_2
{
    internal abstract class Medarbejder : IHarAdresse
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public CprNr CprNr { get; set; }

        public string MedarbejderNr { get; set; }

        private const int _timerPrUge = 37;
        
        public int TimerPrUge //og den tilhørende access metode, bemærk readOnly, dvs get!
        {
            get { return _timerPrUge; }
        }

        public Medarbejder( string navn, string adresse, CprNr cprNr, string medarbejderNr)
        {
            Navn = navn;
            Adresse = adresse;
            CprNr = cprNr;
            MedarbejderNr = medarbejderNr;
        }

        public abstract double BeregnUgeLøn();
        

        public override string ToString()
        {
            return "Medarbejder: "+Navn+" | Adressen: "+Adresse+" | CprNr: "+ CprNr+" | MedarbejderNr: "+MedarbejderNr;
        }
    }
}
