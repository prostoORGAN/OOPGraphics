using System.Drawing;

namespace Lab_1
{

    public class Circle : Figure
    {
        private int x, y, w;

        public Circle(int x, int y, int w)
        {
            this.x = x;
            this.y = y;
            this.w = w;
        }

        public override void draw(Graphics g, Pen myPen)
        {
            g.DrawEllipse(myPen, x, y, w, w);
        }
    }
}
