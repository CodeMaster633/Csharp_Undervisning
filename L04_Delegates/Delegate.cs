using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Delegates
{
    internal class Delegate
    {
        public delegate int Operation(int a, int b);

        public void CalculateAndDisplay(int a, int b, Operation operation) {
            Console.WriteLine("a: "+a+" b: "+b);
            int result = operation(a, b);
            Console.WriteLine("Resultat: "+result);

        }

        public static int Add(int a, int b) { return a + b; }
    }

}
