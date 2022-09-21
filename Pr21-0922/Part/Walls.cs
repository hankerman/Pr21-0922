using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_0922
{
    internal class Walls : IPart
    {

        string name;
        bool prepared;
        public bool Prepared { get; set; }
        public string Name { get { return name; } }
        public Walls()
        {
            prepared = false;
            name = "Walls";
        }

    }
}
