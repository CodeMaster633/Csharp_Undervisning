using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI2Opg1
{
    internal class Bil
    {
        public string Model { get; set; }
        public int Heste { get; set; }
        public Boolean Elbil { get; set; }

        public Bil() { }
        public Bil(string model, int heste, bool elbil)
        {
            Model = model;
            Heste = heste;
            Elbil = elbil;
        }

    }
}
