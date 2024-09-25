using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace HelloWorld
{
    internal class Person
    {


        private string fornavn;

        public Person(string fornavn)
        {
            Fornavn = fornavn;
        }

        public string Fornavn
        {
            get 
            { 
                return fornavn; 
            } 
            set 
            { 
                fornavn = value; 
            }
        }

        public override string? ToString() {
            return "Navn er "+Fornavn;
        }

    }
}
