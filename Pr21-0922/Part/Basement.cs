using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_0922
{
    internal class Basement : IPart
    {
        string name;
        bool prepared;
        public bool Prepared { get ; set ; }

        public string Name { get { return name; } }

        public Basement()
        {
            prepared = false;
            name = "Basement";
        }

    }
}
