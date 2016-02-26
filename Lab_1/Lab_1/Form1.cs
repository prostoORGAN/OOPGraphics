using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 3);

            List list = new List();
            list.add(new Rectangle(10, 10, 10, 70));
            list.add(new Square(100, 100, 10));
            list.add(new Ellipse(150, 150, 10, 30));
            list.add(new Circle(200, 200, 20));
            list.add(new Line(300, 300, 10, 10));

            list.draw(g, myPen);
        }
    }
}
