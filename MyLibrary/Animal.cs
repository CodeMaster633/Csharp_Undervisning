using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Animal : IAnimal
    {
        public Animal() { }
        public Animal(string name) {
        Name = name;
        }

        public string Name { get; set; }

        public bool IsDog() {
            if (Name == "hund"){
                return true;
            } else {
                return false;
            }
        }
    }
}
