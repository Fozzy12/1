using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Taймер включается только после двух несовпадающих
            //значки были показаны игроку,
            //поэтому игнорируем любые щелчки, если таймер работает
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                //Если выбранная метка черная, игрок нажал
                //значок, который уже был открыт
                //игнорировать щелчок
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                //Если firstClicked имеет значение null, это первый значок
                //в паре, на которую нажал игрок,
                //поэтому установите firstClicked на метку, которую игрок
                //нажали, изменяем цвет на красный и возвращаемся
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Red;
                    return;
                }
                //Если игрок зайдет так далеко, таймер не сработает
                //запуск и значение firstClicked не равно нулю,
                //так что это должен быть второй значок, на который нажал игрок
                //Устанавливаем зеленый
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Green;
                CheckForWinner();
                //Если игрок нажал два одинаковых значка, сохраните их
                //черный цвет и сброс firstClicked и Second
                //чтобы игрок мог щелкнуть другой значок
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                //Если игрок зайдет так далеко, игрок
                //щелкнули два разных значка, поэтому запустим
                //таймер (который будет ждать три четверти
                //секунды, а затем скрывает значки)
                timer1.Start();
            }
        }
        Label firstClicked = null;
        Label secondClicked = null;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("Вы выйграли!", "Поздравляю!");
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
