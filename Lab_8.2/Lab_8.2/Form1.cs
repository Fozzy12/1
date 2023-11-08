using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Объявление и инициализация массива Arr размером 10
        private int[] Arr = new int[10];

        private void btnNewArr_Click(object sender, EventArgs e)
        {   // Вызов метода для очистки
            ClearFields();
            // Количество элементов в массиве
            int n = 10;
            // Минимальное значение элементов массива, полученное из текстового поля txtMin
            int a = int.Parse(txtMin.Text);
            // Максимальное значение элементов массива, полученное из текстового поля txtMax
            int b = int.Parse(txtMax.Text);
            // Создание нового экземпляра класса Random для генерации случайных чисел
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                // Присвоение i-му элементу массива случайного значения в диапазоне от a до b
                Arr[i] = r.Next(a, b);
                // Добавление значения i-го элемента массива к тексту элемента lblArr на форме
                lblArr.Text += Arr[i];
                // Добавление запятой после значения i-го элемента массива, кроме последнего элемента массива
                if (i != n) lblArr.Text += ", ";
            }
            // Включение кнопки btnSort
            btnSort.Enabled = true;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {   // получаем размер массива Arr
            int n = Arr.Length;
            // начинаем цикл с индекса 1, так как первый элемент уже считается отсортированным
            for (int i = 1; i < n; i++)
            {
                // вызываем метод Insertion для сортировки подмассива от 0 до i
                Insertion(Arr, i);
            }
            // выводим отсортированный массив в виде строки, разделенной запятыми
            lblResult.Text = string.Join(", ", Arr);
            // отключаем кнопку сортировки после ее выполнения
            btnSort.Enabled = false;
        }
        private void ClearFields()
        {
            // Очищает текстовое поле lblArr и lblResult
            lblArr.Text = "";
            lblResult.Text = "";
            //Отключение кнопки сортировки
            btnSort.Enabled = false;
        }
        private void Insertion(int[] arr, int index)
        {
            // Сохраняем значение элемента, который мы хотим вставить
            int value = arr[index];
            // Начинаем сравнение с предыдущим элементом
            int i = index - 1;
            // Пока индекс i находится в пределах массива и текущий элемент больше значения
            while (i >= 0 && arr[i] > value)
            {
                // Сдвигаем текущий элемент вправо, чтобы освободить место для вставки
                arr[i + 1] = arr[i];
                // Переходим к предыдущему элементу
                i--;
            }
            // Вставляем сохраненное значение в правильное место в отсортированной последовательности
            arr[i + 1] = value;
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
