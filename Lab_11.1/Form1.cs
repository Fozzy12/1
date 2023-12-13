using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Создаем объект Graphics для рисования
            Graphics g = e.Graphics;
            // Создаем объект pen, который используется для рисования линий, задаем цвет черный
            Pen pen = new Pen(Color.Black);

            // Создаем объект brush, который используется для заполнения прямоугольника, задаем цвет коричневый
            Brush brush = new SolidBrush(Color.Brown);
            // Заполняем прямоугольник
            g.FillRectangle(brush, 100, 100, 200, 150);

            // Создаем объект brushs, который используется для заполнения треугольника, задаем цвет зеленый
            Brush brushs = new SolidBrush(Color.Green);
            // Определяем точки треугольника и заполняем его
            Point roofPoint1 = new Point(100, 100);
            Point roofPoint2 = new Point(200, 50);
            Point roofPoint3 = new Point(300, 100);
            Point[] roofPoints = { roofPoint1, roofPoint2, roofPoint3 };
            g.FillPolygon(brushs, roofPoints);

            // Создаем объект brushes, который используется для заполнения двери, задаем цвет красный
            Brush brushes = new SolidBrush(Color.Red);
            // Заполняем дверь
            g.FillRectangle(brushes, 180, 200, 40, 50);

            // Создаем объект brushed, который используется для заполнения окон, задаем цвет синий
            Brush brushed = new SolidBrush(Color.Blue);
            // Заполняем окно 1
            g.FillRectangle(brushed, 120, 130, 40, 40);
            g.DrawLine(pen, 140, 130, 140, 170);
            g.DrawLine(pen, 120, 150, 160, 150);
            g.FillRectangle(brushed, 240, 130, 40, 40);
            // Заполняем окно 2
            g.DrawLine(pen, 260, 130, 260, 170);
            g.DrawLine(pen, 240, 150, 280, 150);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
