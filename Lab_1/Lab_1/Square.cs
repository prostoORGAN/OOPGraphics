using System.Drawing;

namespace Lab_1
{
    public class Square : Figure
    {
        private int x, y, w;

        public Square(int x, int y, int w)
        {
            this.x = x;
            this.y = y;
            this.w = w;
        }

        public override void draw(Graphics g, Pen myPen)
        {
            g.DrawRectangle(myPen, x, y, w, w);
        }
    }
}
