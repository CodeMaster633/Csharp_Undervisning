namespace L10_Entity_Framework.Models
{
    //[Table("Bog")]
    public class Bog
    {
        public int BogID { get; set; }
        public string Name { get; set; }
        public Bibliotek? Bibliotek { get; set; }
        public string BibliotekID { get; set; }


        internal Bog(int id, string name,Bibliotek bibliotek)
        {
            BogID = id;
            Name = name;
            Bibliotek = bibliotek;
            BibliotekID = bibliotek.BibliotekID;
        }
        internal Bog(int id,string name)
        {
            BogID = id;
            Name = name;
        }

        public Bog() { }

        internal Bog(string name)
        {
            Name = name;
        }


    }
}
