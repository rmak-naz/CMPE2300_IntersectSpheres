using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA7_IntersectSpheres
{
    public partial class ICA7_IntersectSpheres : Form
    {
        private List<CDrawer> _canvasList = new List<CDrawer>();
        private List<Square> _nonOverlap = new List<Square>();
        private List<Square> _overlap = new List<Square>();
        private List<Ball> _purpleBalls = new List<Ball>();
        private List<Ball> _salmonBalls = new List<Ball>();

        private delegate void delVoidCDrawerPoint(Point pos, CDrawer dr);

        public enum canvasPick
        {
            left = 0,
            right,
        };

        public ICA7_IntersectSpheres()
        {
            InitializeComponent();
            _canvasList.Add(new CDrawer(800,600,false));
            _canvasList.Add(new CDrawer(800,600,false));

            _canvasList[(int)canvasPick.left].Position = new Point(150, 150);
            _canvasList[(int)canvasPick.right].Position = new Point(950, 150);

            _canvasList[(int)canvasPick.left].MouseLeftClick += ICA7_IntersectSpheres_MouseLeftClick;
            _canvasList[(int)canvasPick.right].MouseMove += ICA7_IntersectSpheres_MouseMove;

        }

        private void ICA7_IntersectSpheres_MouseMove(Point pos, CDrawer dr)
        {
            Invoke(new delVoidCDrawerPoint(GetMouseMove), pos, dr);
        }

        private void ICA7_IntersectSpheres_MouseLeftClick(Point pos, CDrawer dr)
        {
            Invoke(new delVoidCDrawerPoint(GetLeftClick), pos, dr);
        }

        private void B_Distinct_Click(object sender, EventArgs e)
        {
            _overlap = _overlap.Distinct().ToList();
            Render();
        }

        private void B_Clip_Click(object sender, EventArgs e)
        {
            _nonOverlap.RemoveAll(box => IsClipped(box, _canvasList[(int)canvasPick.left]));
            _overlap.RemoveAll(box => IsClipped(box, _canvasList[(int)canvasPick.right]));
            Render();
        }

        private void B_Union_Click(object sender, EventArgs e)
        {
            _canvasList[1].Clear();

            _purpleBalls.Union(_salmonBalls).ToList().ForEach(ball => ball.Render(_canvasList[(int)canvasPick.right], Color.Gold));
        }

        private void B_Intersect_Click(object sender, EventArgs e)
        {
            _canvasList[1].Clear();

            _purpleBalls.Intersect(_salmonBalls).ToList().ForEach(ball => ball.Render(_canvasList[(int)canvasPick.right], Color.Fuchsia));
        }

        private void Render()
        {
            _canvasList.ForEach(canvas => canvas.Clear());

            _nonOverlap.ForEach(box => box.Render(_canvasList[(int)canvasPick.left], Color.Red));
            _overlap.ForEach(box => box.Render(_canvasList[(int)canvasPick.right], Color.Yellow));
            _purpleBalls.ForEach(ball => ball.Render(_canvasList[(int)canvasPick.left], Color.Purple));
            _salmonBalls.ForEach(ball => ball.Render(_canvasList[(int)canvasPick.left], Color.Salmon));

            _canvasList.ForEach(canvas => canvas.Render());
        }

        private void GetLeftClick(Point pos, CDrawer leftCanvas)
        {
            Square newClickSq;
            const int SqSize = 50;

            newClickSq = new Square(new Rectangle(pos.X,pos.Y,SqSize,SqSize));

            if (!_nonOverlap.Contains(newClickSq))
            {
                _nonOverlap.Add(newClickSq);
            }
            else
            {
                _overlap.Add(newClickSq);
            }

            Render();
        }

        private void GetMouseMove(Point pos, CDrawer rightCanvas)
        {
            if (RB_Purple.Checked)
            {
                _purpleBalls.Add(new Ball(pos));
            }
            else
            {
                _salmonBalls.Add(new Ball(pos));
            }

            Render();
        }

        private bool IsClipped(Square box, CDrawer canvas)
        {
            if (canvas.ScaledWidth - box._box.X < box._box.Width / 2)
                return true;
            else if (box._box.X < box._box.Width / 2)
                return true;
            else if (canvas.ScaledHeight - box._box.Y < box._box.Height / 2)
                return true;
            else if (box._box.Y < box._box.Height / 2)
                return true;
            else
                return false;
        }
    }
}
