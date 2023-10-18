using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Секундомер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tmp;
        int min;
        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            int min = Int32.Parse(txtMinutes.Text);
            //после 59 секунд идет 1 минута
            if (tmp >= 59)
            {
                min += 1;
                txtMinutes.Text = min.ToString();
                tmp = 0;
                txtSeconds.Text = tmp.ToString();
            }
            else
            {
                tmp += 1;
                txtSeconds.Text = tmp.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = !tmrSecundomer.Enabled;
        }
        //время обнуляется
        private void Clear_Click(object sender, EventArgs e)
        {
            tmp = 0;
            txtSeconds.Text = tmp.ToString();
            min = 0;
            txtMinutes.Text = min.ToString();
        }
        //выводится актуальное время
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            textBox1.Text = currentTime.ToString();
        }
    }
}
