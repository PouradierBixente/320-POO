using Drones.Helpers;
using Drones.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Charger
{
    internal class Charger
    {
        public int X;
        public int Y;

        public Charger(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(X, Y, 20, 20);
        }
    }
}
