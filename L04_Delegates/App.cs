using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L04_Delegates.Opg4_2;

namespace L04_Delegates
{
    internal class App
    {
        static void Main(string[] args)
        {
            PowerPlant powerPlant = new PowerPlant();
            powerPlant.SetWarning(WarningToConsole);
            powerPlant.SetWarning(WarningToConsole2);
            powerPlant.HeatUp();


            //string navn = "Benjamin";
            //Console.WriteLine("Lang:" + navn.Lang(6));

            //Console.WriteLine("Calculate and display: ");
            //Delegate dele = new Delegate();
            //dele.CalculateAndDisplay(3,5,Delegate.Add);
        }

        public static void WarningToConsole() { Console.WriteLine("Advarsel"); }
        public static void WarningToConsole2() { Console.WriteLine("Wuups"); }

    }


}
