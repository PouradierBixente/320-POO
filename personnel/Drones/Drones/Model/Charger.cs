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
        private int X;
        private int Y;

        public Charger(int x, int y)
        {
            this.X1 = x;
            this.Y1 = y;
        }

        public int X1 { get => X; set => X = value; }
        public int Y1 { get => Y; set => Y = value; }

        public void Render(BufferedGraphics drawingSpace)
        {
            Pen pen = new Pen(Color.Black, 3);
            drawingSpace.Graphics.DrawEllipse(pen, X1, Y1, 20, 20);
        }
    }
}
