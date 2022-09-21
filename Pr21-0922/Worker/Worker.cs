using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_0922
{
    internal class Worker : IWorker
    {
        string name;
        bool work;
        public bool Work { get; }
        public string Name { get { return name; } }

        public Worker(bool work, string name)
        {
            this.work = work;
            this.name = name;
        }

        public int WillBeChecked(House house)
        {

            for(int i = 0; i < house.hous.Count; i++)
            {

                if (!house.hous[i].Prepared)
                {
                    return i;
                }

            }

            return -1;
        }

        public void Building(ref House home)
        {
            if (work)
            {

                int moment = WillBeChecked(home);
                if(moment == 0)
                {
                    Console.WriteLine($"{name} залевает фундамент");
                    home.hous[moment].Prepared = true;
                }
                else if(moment == 1 || moment == 2 || moment == 3 || moment == 4)
                {
                    Console.WriteLine($"{name} строит стену");
                    home.hous[moment].Prepared = true;
                }
                else if(moment == 5)
                {
                    Console.WriteLine($"{name} ставит дверь");
                    home.hous[moment].Prepared = true;
                }
                else if (moment == 6 || moment == 7 || moment == 8 || moment == 9)
                {
                    Console.WriteLine($"{name} ставит окно");
                    home.hous[moment].Prepared = true;
                }
                else if(moment == 10)
                {
                    Console.WriteLine($"{name} кроет крышу");
                    home.hous[moment].Prepared = true;
                }
                else
                {
                    Console.WriteLine("Перекур");                    
                }


            }
            else
            {
                Random rand = new Random();
                int it = rand.Next(1, 3);
                if (it == 1)
                {
                    Console.WriteLine($"{name} спит");
                } else if (it == 2)
                {
                    Console.WriteLine($"{name} кушает");
                }
                else if (it == 3)
                {
                    Console.WriteLine($"{name} считает облока");
                }            
                else
                {
                    Console.WriteLine($"{name} в туалете");
                }

            }
        }

    }
}
