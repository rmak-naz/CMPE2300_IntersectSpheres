using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA7_IntersectSpheres
{
    class Square
    {
        public Rectangle _box;

        public Square(Rectangle box)
        {
            _box = box;
            
        }

        public void Render(CDrawer canvas, Color sColor)
        {
            canvas.AddCenteredRectangle(_box.X, _box.Y, _box.Width, _box.Height, sColor);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Square))
                throw new ArgumentException("Incorrect type in CompareTo!");

            Square sObj = (Square)obj;

            return _box.IntersectsWith(sObj._box);    
        }

        public override int GetHashCode()
        {
            return 1;
        }

        
    }
}
