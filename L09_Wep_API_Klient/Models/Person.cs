namespace L09_Web_API_Klient.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

    }
}
