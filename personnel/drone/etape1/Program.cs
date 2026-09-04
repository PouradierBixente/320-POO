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
            Drone drone = new Drone();

            drone.change();
            drone.draw();
            Thread.Sleep(1000);
        }
    }
}
