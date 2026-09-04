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
            Drone[] drones = new Drone[] { 
                new Drone(5, 10, 50), 
                new Drone(8, 20, 20),
                new Drone(10, 0, 40),
                new Drone(6, 80, 80),
                new Drone(7, 70, 70),
                new Drone(9, 50, 30),
                new Drone(15, 100, 40),
                new Drone(2, 90, 10),
                new Drone(0, 15, 5),
                new Drone(1, 40, 30),
            };

           
            while (OneIsAlive(drones))
            {
                Console.Clear();

                foreach (Drone drone in drones)
                {
                    drone.Change();
                    drone.Draw();
                }

                Thread.Sleep(100);
            }
        }

        static bool OneIsAlive(Drone[] drones)
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
