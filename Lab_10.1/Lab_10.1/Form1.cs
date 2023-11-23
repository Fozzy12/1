using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonСalc_Click(object sender, EventArgs e)
        {   
            // Получаем значения из текстовых полей
            double Xmin = double.Parse(textBoxXmin.Text);
            double Xmax = double.Parse(textBoxXmax.Text);
            double Step = double.Parse(textBoxStep.Text);
            // Вычисляем количество точек
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            // Создаем массивы для значений x, y1 и y2
            double[] x = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            // Заполняем массивы значениями
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                // Задаем значение y1[i] как синус x[i]
                y1[i] = Math.Sin(x[i]);
                // Задаем значение y2[i] как косинус x[i]
                y2[i] = Math.Cos(x[i]);
            }
            // Устанавливаем минимальное и максимальное значения оси X на графике
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            // Устанавливаем интервал сетки по оси X на графике
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Связываем значения массивов с сериями графика
            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 button1 = new Form2();
            button1.ShowDialog();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
