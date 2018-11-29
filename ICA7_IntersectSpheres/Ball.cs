using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA7_IntersectSpheres
{
    class Ball
    {
        public Point _pos;

        public Ball(Point pos)
        {
            _pos = pos;

        }

       
        public void Render(CDrawer canvas, Color bColor)
        {
            const int ballSize = 10;

            canvas.AddCenteredEllipse(_pos.X, _pos.Y, ballSize, ballSize, bColor);
            canvas.Render();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ball))
                throw new ArgumentException("Incorrect type in CompareTo!");

            Ball bObj = (Ball)obj;

            return bObj._pos.Equals(_pos);
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
