using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Delegates.Opg4_6
{
    internal class App
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Person("Benjamin", 26, 75));
            personer.Add(new Person("Jørgen", 99, 100));
            personer.Add(new Person("Bent", 13, 60));

            personer.Sort(new ByWeightSorter());

            foreach (Person person in personer)
            {
                Console.WriteLine(person.Name + " "+person.Weigth);

            }
        }
    }
}
