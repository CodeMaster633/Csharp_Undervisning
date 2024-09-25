using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Delegates.Opg4_2
{
    internal class PowerPlant
    {
        public delegate void Warning();
        public Warning _Warning;

        public void SetWarning(Warning wa)
        {
            _Warning += wa;
        }

        public void HeatUp()
        {
            Random rnd = new Random();

            if (rnd.Next(100) > 50) _Warning.Invoke();
        }
    }
}
