using System;
using System.Collections.Generic;
using System.Linq;
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
            int posY = 0;
            int posX = 0;
            int batterie = 50;
            int batterie2 = 50;
            int batterie3 = 50;

            while (batterie >= 2)
            {
                for(posY = 0; posY <= 20; posY += 10)
                {
                    dessinDrone(posX, posY);
                }
                posX++;
                batterie = etatDrone(batterie);
                batterie2 = etatDrone(batterie2);
                batterie3 = etatDrone(batterie3);
                Thread.Sleep(150);
                Console.Clear();
            }

            for (posY = 0; posY <= 20; posY += 10)
            {
                dessinDroneMort(posX, posY);
            }
        }

        static void dessinDrone (int posX, int POSY)
        {
            string drone = "x-o-x";


            Console.SetCursorPosition(posX, POSY);
            Console.WriteLine(drone);
        }

        static int etatDrone(int batterie)
        {
            batterie -= 2;
            return batterie;
        }

        static void dessinDroneMort(int posX, int POSY)
        {
            string droneDead = "____";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(posX, POSY);
            Console.WriteLine(droneDead);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
