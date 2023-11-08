using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Объявление и инициализация массива Arr размером 10
        private int[] Arr = new int[10];

        private void btnNewArr_Click(object sender, EventArgs e)
        {
            // Очищаем поля ввода и вывода
            ClearFields();
            // Получаем значения из текстовых полей txtMin и txtMax и преобразуем их в целочисленный тип
            int n = 10;// Размер массива
            int a = int.Parse(txtMin.Text);// Минимальное значение
            int b = int.Parse(txtMax.Text);// Максимальное значение
            // Создаем объект класса Random для генерации случайных чисел
            Random r = new Random();
            // Заполняем массив Arr случайными числами в заданном диапазоне
            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(a, b);
                // Выводим элемент массива Arr в метку lblArr
                lblArr.Text += Arr[i];
                // Если не последний элемент массива, добавляем запятую и пробел
                if (i != n) lblArr.Text += ", ";
            }
            // Включаем возможность сортировки массива
            btnSort.Enabled = true;
           
        }

        private int MinNumber(int [] x, int m)
        {
            // Присваиваем min значение элемента массива с индексом m
            int min = x[m];
            // Присваиваем MinN значение m
            int MinN = m;
            // Цикл начинается с индекса m и продолжается до конца массива
            for (int i = m; i<x.Length; i++)
            {
                // Если текущий элемент массива меньше min
                if (x[i] < min)
                {
                    // Обновляем значение min на текущий элемент
                    min = x[i];
                    // Обновляем значение MinN на текущий индекс
                    MinN = i;
                }
            }
            // Возвращаем индекс наименьшего элемента
            return MinN;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Объявляем переменные k и t для использования во временном хранении и смене значений
            int k, t;
            // Итерируемся по всем элементам массива Arr
            for (int i = 0; i < Arr.Length; i++)
            {
                // Находим индекс минимального значения в подмассиве, начинающемся с индекса i
                k = MinNumber(Arr, i);
                // Сохраняем текущее значение элемента массива Arr[i] в переменную t
                t = Arr[i];
                // Заменяем значение Arr[i] на значение Arr[k]
                Arr[i] = Arr[k];
                // Заменяем значение Arr[k] на сохраненное в переменной t значение
                Arr[k] = t;
                // Добавляем значение Arr[i] в текстовую метку lblResult с пробелом или запятой 
                lblResult.Text += Arr[i];
                if (i != Arr.Length - 1) { lblResult.Text += ", "; }
            }
            // Отключаем кнопку "Сортировать"
            btnSort.Enabled = false;
        }

        private void ClearFields()
        {   //Очищает текстовое поле lblArr и lblResult
            lblArr.Text = "";
            lblResult.Text = "";
            // Отключаем кнопку "Сортировать"
            btnSort.Enabled = false;
        }
    }
}
