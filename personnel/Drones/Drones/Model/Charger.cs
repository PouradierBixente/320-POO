using Drones.Helpers;
using Drones.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Drones
{
    public class Charger
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
            Pen MyPen = new Pen(Color.Black, 3);
            drawingSpace.Graphics.DrawEllipse(MyPen, X, Y, 20, 20);
        }
    }
}
