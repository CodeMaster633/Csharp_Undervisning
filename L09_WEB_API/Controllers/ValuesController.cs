using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L09_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Person> Persons { get; set; } = new List<Person>() { new Person(1, "Benjamin", 26), new Person(2, "Niels", 28) };


        [HttpGet]
        [Route("getPersoner")]
        public List<Person> getPersoner()
        {
            return Persons;
        }

        [HttpGet]
        [Route("getPersonPrId")]

        public Person getPersonById(int id)
        {
            return Persons.Where(p => p.Id == id).First();
        }

        [HttpPost]
        public Person addPerson(Person p)
        {
            Persons.Add(p);
            Console.WriteLine("addPerson() kaldet - "+p.Name);
            return p;
        }
    }
}
