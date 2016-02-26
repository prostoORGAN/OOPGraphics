using System.Drawing;

namespace Lab_1
{
    public class Line : Figure
    {
        private int x1, y1, x2, y2;

        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x1;
            this.y2 = y2;
        }

        public override void draw(Graphics g, Pen myPen)
        {
            g.DrawLine(myPen, x1, y1, x2, y2);
        }
    }
}
