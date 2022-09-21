using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_0922
{
    internal class Team
    {

        public List<IWorker> workers;

        public Team()
        {
            workers = new List<IWorker>();
            workers.Add(new TeamLeader(true, "Виктор Петрович"));
            workers.Add(new Worker(true, "Семеныч"));
            workers.Add(new Worker(true, "Василич"));
            workers.Add(new Worker(true, "Радионович"));
            workers.Add(new Worker(true, "Валентиныч"));

        }




    }
}
