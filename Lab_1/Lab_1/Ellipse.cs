using System.Drawing;

namespace Lab_1
{
    public class Ellipse : Figure
    {
        private int x, y, w, h;

        public Ellipse(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public override void draw(Graphics g, Pen myPen)
        {
            g.DrawEllipse(myPen, x, y, w, h);
        }
    }
}
