using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace L04_Delegates.Opg4_6
{
    public class Person
    {
        public string Name;
        public int Weigth;
        public int Age;

        public Person(string name, int age, int weigth) {
        Name = name;
            Weigth = weigth;
            Age = age;
        
        }

    }
    public class ByAgeSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y) {

            if (x == null || y == null) {
                return 0;
            }

            return x.Age.CompareTo(y.Age);
        }

    }
public class ByWeightSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {

            if (x == null || y == null)
            {
                return 0;
            }

            return x.Weigth.CompareTo(y.Weigth);
        }
    }
public class ByNameSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {

            if (x == null || y == null)
            {
                return 0;
            }

            return x.Name.CompareTo(y.Name);
        }
    }
}
