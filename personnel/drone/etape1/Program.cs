using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace etape1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Drone> drones = new List<Drone> { 
                new Drone(5, 10, 50), 
                new Drone(8, 20, 20),
            };

            int count = 0;
           
            while (OneIsAlive(drones))
            {
                Console.Clear();

                foreach (Drone drone in drones)
                {
                    drone.Change();
                    drone.Draw();
                }

                Thread.Sleep(100);
                count++;

                if (count == 10){
                    drones.Add(new Drone(5, 10, 50));
                }

            }
        }

        static bool OneIsAlive(List<Drone> drones)
        {
            foreach (Drone drone in drones)
            {
                if (drone.Battery > 0)
                    return true;
            }
            return false;
        }
    }
}
