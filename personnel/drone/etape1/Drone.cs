using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace etape1
{
    internal class Drone
    {
        private int _posX;
        private int _posY;
        private int _battery;

        public int Battery { get => _battery; }

        public Drone(int posX, int posY, int battery)
        {
            this._posX = posX;
            this._posY = posY;
            this._battery = battery;
        }

        public Drone()
        {
            this._posX = 0;
            this._posY = 0;
            this._battery = 40;
        }


        public void Change()
        {
            if (_battery <= 0) return;
            _battery -= 2;
            _posX += 1;
        }

        public void Draw()
        {
            if (Battery > 0)
            {
                Console.SetCursorPosition(_posX, _posY);
                Console.WriteLine("x-o-x");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(_posX, _posY);
                Console.WriteLine("_____");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
