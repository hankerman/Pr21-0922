using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_0922
{
    internal class Program
    {
        static void Main(string[] args)
        {

            House house = new House();
            Team team = new Team();

            while (!house.comlite)
            {

                team.workers[0].Building(ref house);
                team.workers[1].Building(ref house);


            }

        }
    }
}
