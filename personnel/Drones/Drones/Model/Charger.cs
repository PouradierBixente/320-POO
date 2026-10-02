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
<<<<<<< HEAD
        private int _x;
        private int _y;

        public Charger(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public void Render(BufferedGraphics drawingSpace)
        {
            Pen MyPen = new Pen(Color.Black, 3);
            drawingSpace.Graphics.DrawEllipse(MyPen, _x, _y, 20, 20);
=======
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
>>>>>>> 341c3d4d2c0a0139acc2a45688aa4ca76190f22c
        }
    }
}
