namespace DataAccessStuderende2.Model
{
    public class Studerende
    {
        public Studerende() { }
        
            public int StuderendeId { get; set; } 
            public string Navn { get; set; }
            public DateTime Studiestart { get; set; }
            public int Alder { get; set; }
            public Studietype Studietype { get; set; }

            public Studerende(int studerendeId, string navn, DateTime studiestart, int alder, Studietype studietype)
            {
                StuderendeId = studerendeId;
                Navn = navn;
                Studiestart = studiestart;
                Alder = alder;
                Studietype = studietype;
            }
        }

    

    public enum Studietype
    {
        Master,
        Bachelor,
        Enkeltfag,
        Videreuddannelse
    }
}
