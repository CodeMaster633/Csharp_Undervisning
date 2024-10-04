namespace L10_Entity_Framework.Models
{
    public class Bibliotek
    {
        public string BibliotekID { get; set; }
        public string BibName { get; set; }
        public List<Bog> Boger = new List<Bog>() { };


        public Bibliotek(string bibID, string bibName)
        {
            BibName = bibName;
            BibliotekID = bibID;
        }
        public Bibliotek() { }

    }
}
