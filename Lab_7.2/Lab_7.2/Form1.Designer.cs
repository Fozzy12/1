namespace Lab_7._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst = new System.Windows.Forms.ListBox();
            this.lstFromfile = new System.Windows.Forms.ListBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(24, 65);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(170, 108);
            this.lst.TabIndex = 0;
            // 
            // lstFromfile
            // 
            this.lstFromfile.FormattingEnabled = true;
            this.lstFromfile.Location = new System.Drawing.Point(233, 65);
            this.lstFromfile.Name = "lstFromfile";
            this.lstFromfile.Size = new System.Drawing.Size(170, 108);
            this.lstFromfile.TabIndex = 1;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(24, 23);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(24, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить список в файл";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.btnOpen.Location = new System.Drawing.Point(233, 179);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(170, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Загрузить данные из файла";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить элемент в список";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Путь к файлу";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(24, 208);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(170, 20);
            this.txt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 271);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lstFromfile);
            this.Controls.Add(this.lst);
            this.Name = "Form1";
            this.Text = "Работа с файлами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.ListBox lstFromfile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt;
    }
}

