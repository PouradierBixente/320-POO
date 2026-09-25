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
        private int _x;
        private int _y;

        public Charger(int x, int y)
        {
            this._x = x;
            this._y = y;
        }


        public void Render(BufferedGraphics drawingSpace)
        {
            Pen MyPen = new Pen(Color.Black, 3);
            drawingSpace.Graphics.DrawEllipse(MyPen, _x, _y, 20, 20);
        }
    }
}
