using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анимация
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //перемещение picturebox вправо
        private void tmr_Tick(object sender, EventArgs e)
        {
       
            if (pct.Left + pct.Width + 20 > this.ClientSize.Width)
            {
                tmr.Enabled = false;
            }
            else
            {
                pct.Left += 20;
            }
        }
        //при нажатии на кнопку запускаетя таймер
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmr.Interval = 50;
            pct.Left = 0;
            tmr.Enabled = !tmr.Enabled;
            btnStart.Text = tmr.Enabled ? "Стоп" : "Старт";
        }
        //кнопка выхода
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
