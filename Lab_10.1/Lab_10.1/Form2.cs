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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonСalc_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
            double Xmin = double.Parse(textBoxXmin.Text);
            double Xmax = double.Parse(textBoxXmax.Text);
            double Step = double.Parse(textBoxStep.Text);
            double b = double.Parse(textB.Text);
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
                y1[i] = Math.Pow(x[i], 2) + Math.Tan(5 * x[i] + b / x[i]);
                y2[i] = Math.Sin(x[i]);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
