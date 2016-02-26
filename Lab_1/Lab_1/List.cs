using System.Drawing;

namespace Lab_1
{
    class List
    {
        const int MaxValue = 5;
        private Figure[] figureList = new Figure[MaxValue];
        private int number = 0;
        public void add(Figure figure)
        {
            figureList[number] = figure;
            number++;
        }

        public void draw(Graphics g, Pen myPen)
        {
            for (int i = 0; i < number; i++)
            {
                figureList[i].draw(g, myPen);
            }
        }
    }
}
