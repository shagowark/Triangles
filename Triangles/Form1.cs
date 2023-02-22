using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
{
    public partial class Form1 : Form
    {
        
        List<Triangle> triangles = new List<Triangle>();
        public Form1()
        {
            InitializeComponent();
        }

        // метод для рисования
        private void MyPictureBox_Paint(object sender, PaintEventArgs e)
        {
            int width = myPictureBox.Width; // получаем ширину и высоту именно myPictureBox и используем их
            int height = myPictureBox.Height;
            Bitmap myBitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(myBitmap); // получаем рисовашку

            g.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height); // заполняем все белым
            g.DrawLine(new Pen(Color.Black), 0, height / 2, width, height / 2);
            g.DrawLine(new Pen(Color.Black), width / 2, 0, width / 2, height);
            foreach (Triangle triangle in triangles) // перебираем все треугольники
            {
                Point[] points = { triangle.p1, triangle.p2, triangle.p3 };
                g.FillPolygon(new SolidBrush(Color.Purple), points); // с заливкой, сам трегольник
                g.DrawPolygon(new Pen(Color.Black), points); // черная окантовка
            }
            myPictureBox.Image = myBitmap;
            g.Dispose();;
        }


        class Triangle // класс описывающий треугольник
        {
            public Point p1;
            public Point p2;
            public Point p3;

            public Triangle(Point p1, Point p2, Point p3)
            {
                this.p1 = p1;
                this.p2 = p2;
                this.p3 = p3;
            }
        }

        private void ButtonDraw_Click(object sender, EventArgs e) // обратываем клик на кнопку "рисовать"
        {
            // считываем инфу из полей и создаем по ней новые объекты точек
            Point p1 = new Point(myPictureBox.Width/2 + Int32.Parse(textBoxX1.Text), myPictureBox.Height/2 - Int32.Parse(textBoxY1.Text));
            Point p2 = new Point(myPictureBox.Width/2 + Int32.Parse(textBoxX2.Text), myPictureBox.Height/2 - Int32.Parse(textBoxY2.Text));
            Point p3 = new Point(myPictureBox.Width/2 + Int32.Parse(textBoxX3.Text), myPictureBox.Height/2 - Int32.Parse(textBoxY3.Text));
            // по точкам создаем новый объект треугольника
            Triangle triangle = new Triangle(p1, p2, p3);
            triangles.Add(triangle); // добавляем треугольник в список всех треугольников
            Refresh();
        }

        // обнуляем все поля
        private void ButtonClearText_Click(object sender, EventArgs e)
        {
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            textBoxX3.Text = "";
            textBoxY1.Text = "";
            textBoxY2.Text = "";
            textBoxY3.Text = "";
        }

        // обнуляем список треугольников и вызываем перерисовку -> нарисуется белый фон,
        // а треугольников для рисования нет. т.е. очистили панель
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            triangles.Clear();
            Refresh();
        }

        Point currentPoint = new Point(-1, -1);
        Triangle currentTriangle = null;
        const int EPS = 5;
   
        private Boolean IsNear(Point p1, Point p2)
        {
            if (Math.Abs(p1.X - p2.X) <= EPS && Math.Abs(p1.Y - p2.Y) <= EPS)
            {
                return true;
            }
            return false;
        }

        private void MyPictureBox_MouseDown(object sender, MouseEventArgs e)
        {

            Point click = new Point(e.X, e.Y);
            foreach (Triangle triangle in triangles)
            {
                if (IsNear(click, triangle.p1))
                {
                    currentPoint = triangle.p1;
                    currentTriangle = triangle;
                    break;
                }
                else if (IsNear(click, triangle.p2))
                {
                    currentPoint = triangle.p2;
                    currentTriangle = triangle;
                    break;
                }
                else if (IsNear(click, triangle.p3))
                {
                    currentPoint = triangle.p3;
                    currentTriangle = triangle;
                    break;
                }
            }
            Refresh();
        }

        private void MyPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            currentPoint.X = -1;
            currentPoint.Y = -1;
            currentTriangle = null;
            Refresh();
        }

        private void MyPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentTriangle == null)
            {
                return;
            }
            Point currentPosition = new Point(e.X, e.Y);
            Size shift = new Size(currentPosition.X - currentPoint.X, currentPosition.Y - currentPoint.Y);
            currentTriangle.p1 += shift;
            currentTriangle.p2 += shift;
            currentTriangle.p3 += shift;
            currentPoint += shift;
            Refresh();
        }    
    }
}
