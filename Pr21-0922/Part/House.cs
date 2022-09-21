using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_0922
{
    internal class House
    {

        public bool comlite;
        public List<IPart> hous;


        public House()
        {
            
            comlite = false;
            hous = new List<IPart>();
        }
               

    }
}
