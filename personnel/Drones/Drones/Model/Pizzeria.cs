using Drones.Helpers;
using Drones.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drones
{
    public class Pizzeria
    {
        private int _x;
        private int _y;
        private const int SIZEELLIPSE = 50;

        public Pizzeria(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }


        #region  ================ Rendu graphique  ================

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            Pen pen = new Pen(Color.Gray, 3);
            drawingSpace.Graphics.DrawRectangle(pen, X - SIZEELLIPSE / 2, Y - SIZEELLIPSE / 2, SIZEELLIPSE, SIZEELLIPSE);

        }
        #endregion

        public static void RegisterPizzeria(List<Pizzeria> Pizzi)
        {
            
            int size = 25;
            int x = GeneratorHelpers.Generating(0 + SIZEELLIPSE, Config.AIRSPACE_WIDTH - SIZEELLIPSE);
            int y = GeneratorHelpers.Generating(0 + SIZEELLIPSE, Config.AIRSPACE_HEIGHT - SIZEELLIPSE);

            foreach (Pizzeria p in Pizzi)
            {
                if ((x + size >= p.X - size) && (x - size <= p.X + size) && (y + size >= p.Y - size) && (y - size <= p.Y + size))
                {
                    throw new Exception("Pizzeria se chevauche.");
                }
            }
            Pizzi.Add(new Pizzeria(x,y));
            
        }
    }
}
