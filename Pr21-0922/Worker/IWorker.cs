using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_0922
{
    internal interface IWorker
    {

        string Name { get;}

        bool Work { get; }
        int WillBeChecked( House home);
        void Building(ref House home);

    }
}
