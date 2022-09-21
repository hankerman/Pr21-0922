using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_0922
{
    internal class TeamLeader : IWorker
    {
        string name;
        bool work;
        public string Name { get { return name; }}
        public bool Work { get; }

        public TeamLeader(bool work, string name )
        {
            this.name = name;
            this.work = work;
        }
        
        public int WillBeChecked(House home)
        {
            for (int i = 0; i < home.hous.Count - 1; i++)
            {

                if (home.hous[i].Prepared)
                {
                    Console.WriteLine($"{home.hous[i]} complit");
                }

            }

            return -1;
        }

        public void Building(ref House home)
        {

            if (!home.comlite)
            {
                
                if(home.hous.Count == 0)
                {
                    home.hous.Add(new Basement());
                }                
                else if (home.hous.Count == 1 || home.hous.Count == 2 || home.hous.Count == 3 || home.hous.Count == 4)
                {
                    home.hous.Add(new Walls());
                }
                else if (home.hous.Count == 5)
                {
                    home.hous.Add(new Door());
                }
                else if (home.hous.Count == 6 || home.hous.Count == 7 || home.hous.Count == 8 || home.hous.Count == 9)
                {
                    home.hous.Add(new Window());
                }
                else if (home.hous.Count == 10)
                {
                    home.hous.Add(new Roof());
                }
                                

            }
            else
            {
                Console.WriteLine("Дом готов");
            }
        }

        public void Info(House home)
        {
            foreach(var h in home.hous)
            {
                Console.WriteLine($"{h.Name} -  {h.Prepared}");
            }
        }


    }
}
