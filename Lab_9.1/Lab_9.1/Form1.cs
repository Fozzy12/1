using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int NumberSymbols(string stroka, char symbol)
        {
            // переменная для подсчета количества символов symbol
            int k = 0;
            // цикл, проходящий по каждому символу в строке stroka
            for (int i = 0; i < stroka.Length; i++)
            {
                // проверяем, равен ли текущий символ symbol
                if (stroka[i] == symbol)
                {
                    // увеличиваем значение переменной k на 1, если текущий символ равен symbol
                    k += 1;
                }
            }
            // возвращаем количество найденных символов symbol
            return k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Присваиваем переменной input значение текстового поля txtString.Text
            string input = txtString.Text;
            // Присваиваем переменной symbol значение первого символа в текстовом поле txtSymbol
            char symbol = txtSymbol.Text[0];
            // Вызываем метод NumberSymbols с параметрами input и symbol и присваиваем результат переменной count
            int count = NumberSymbols(input, symbol);
            // Устанавливаем в текстовое поле txtKolvo значение переменной count, преобразованное в строку
            txtKolvo.Text = count.ToString();
            // Инициализируем переменную maCount со значением 0
            int maCount = 0;
            // Проходим по каждому символу в строке input до предпоследнего символа
            for (int i = 0; i < input.Length - 1; i++)
            {
                // Если текущий символ и следующий символ равны 'м' и 'а' соответственно, увеличиваем значение переменной maCount на 1
                if (input[i] == 'м' && input[i + 1] == 'а')
                {
                    maCount++;
                }
            }
            // Устанавливаем в текстовое поле txtSymbolOut значение переменной maCount, преобразованное в строку
            txtSymbolOut.Text = maCount.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
