using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Добавляем текст из текстового поля txt в элемент списка lst
            lst.Items.Add(txt.Text);
            // Очищаем текстовое поле txt после добавления элемента в список
            txt.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Получаем имя файла из текстового поля txtFileName
            string fileName = txtFileName.Text;
            // Проверяем, существует ли файл с таким именем
            if (File.Exists(fileName))
            {
                // Если файл существует, удаляем его
                File.Delete(fileName);
            }
            // Создаем новый файл с заданным именем и размером буфера 1024 байта
            using (FileStream fs = File.Create(fileName, 1024))
            using(BinaryWriter bw = new BinaryWriter(fs))
            {
                // Записываем в файл содержимое элементов списка lst
                for (var i = 0; i < lst.Items.Count; i++)
                {
                    // Записываем строковое представление текущего элемента списка в файл
                    bw.Write(lst.Items[i].ToString());
                }
                // Закрываем и сохраняем изменения в файле
                bw.Close();
                fs.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Получение имени файла из текстового поля txtFileName
            string fileName = txtFileName.Text;
            // Очистка элемента lstFromfile
            lstFromfile.Items.Clear();
            // Использование блока using для создания и автоматического закрытия FileStream и BinaryReader
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                // Проверяем, есть ли данные для чтения
                while (br.PeekChar() != -1)
                {
                    // Добавление прочитанных данных в элемент lstFromfile
                    lstFromfile.Items.Add(br.ReadString());
                }
                // Закрытие BinaryReader и FileStream
                br.Close();
                fs.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
