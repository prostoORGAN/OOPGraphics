using System.Drawing;

namespace Lab_1
{
    public class Rectangle : Figure
    {
        private int x, y, w, h;

        public Rectangle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public override void draw(Graphics g, Pen myPen)
        {
            g.DrawRectangle(myPen, x, y, w, h);
        }
    }
}