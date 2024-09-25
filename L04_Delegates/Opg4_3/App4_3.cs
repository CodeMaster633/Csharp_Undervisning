using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Delegates.Opg4_3
{
    internal class App4_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Factorial(5));
            Console.WriteLine(4.Factorial());
            
            Console.WriteLine( Power(5,2));
            Console.WriteLine(4.Power(2));


        }

        public static int Factorial(int n) {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                 result = i * result;
            }
            return result;
        }

        public static int Power(int n,int p)
        {
            int result = 1;

            for (int i = 1; i <= p; i++)
            {
                result = result*n;
            }
            return result;
        }
    }
}
