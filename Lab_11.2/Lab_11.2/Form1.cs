using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11._2
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
            Graphics graphics = e.Graphics;

            // Указываем значения ширины, высоты и глубины нашего прямоугольника, а также его координаты
            int width = 200;
            int height = 100;
            int depth = 50;
            int x = 100;
            int y = 100;

            // Рисуем прямоугольник черным цветом с помощью метода
            graphics.DrawRectangle(Pens.Black, x, y, width, height);
            // Рисуем линии, образующие трехмерные вершины нашего прямоугольника
            // Вершина 1
            graphics.DrawLine(Pens.Black, x, y, x - depth, y - depth);
            // Вершина 2
            graphics.DrawLine(Pens.Black, x + width, y, x + width - depth, y - depth);
            // Вершина 3
            graphics.DrawLine(Pens.Black, x - depth, y - depth, x + width - depth, y - depth);
            // Вершина 4
            graphics.DrawLine(Pens.Black, x, y + height, x - depth, y + height - depth);
            // Вершина 5
            graphics.DrawLine(Pens.Black, x, y, x - depth, y - depth);
            // Вершина 6
            graphics.DrawLine(Pens.Black, x + width, y, x + width - depth, y - depth);
            // Вершина 7
            graphics.DrawLine(Pens.Black, x + width, y, x + width, y + height);
            // Вершина 8
            graphics.DrawLine(Pens.Black, x - depth, y, x - depth, y + height - depth);
            // Вершина 9
            graphics.DrawLine(Pens.Black, x - depth, y - depth, x - depth, y + height - depth);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
